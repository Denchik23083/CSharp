using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;
using J.A.R.V.I.S.Db;

namespace J.A.R.V.I.S
{
    public partial class MainForm : Form
    {
        public SpeechRecognitionEngine Sir = new();
        public SpeechRecognitionEngine StartListening = new();
        public SpeechSynthesizer Jarvis = new();
        public JarvisContext Context = new();

        public MainForm()
        {
            InitializeComponent();

            Settings();
        }

        private void Settings()
        {
            Context.Database.EnsureCreated();

            Jarvis.SelectVoice("Microsoft David Desktop");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            AI.Items.Add("Jarvis: Welcome back sir! How can I help you?");
            Jarvis.SpeakAsync("Welcome back sir! How can I help you?");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Sir.SetInputToDefaultAudioDevice();
            Sir.LoadGrammarAsync(GetGrammar());
            Sir.SpeechRecognized += Default_SpeechRecognition;
            Sir.RecognizeAsync(RecognizeMode.Multiple);

            StartListening.SetInputToDefaultAudioDevice();
            StartListening.LoadGrammarAsync(GetGrammar());
            StartListening.SpeechRecognized += StartListening_SpeechRecognized;
        }

        private void Default_SpeechRecognition(object? sender, SpeechRecognizedEventArgs e)
        {
            var mySpeech = e.Result.Text;

            I.Items.Add("I: " + mySpeech);

            switch (mySpeech)
            {
                case "Jarvis":
                    AI.Items.Add("Jarvis: I am here. Waiting for instructions");
                    Jarvis.SpeakAsync("I am here. Waiting for instructions");
                    break;

                case "Who are you?":
                    AI.Items.Add("Jarvis: I am J.A.R.V.I.S. Just A Rather Very Intelligent System");
                    Jarvis.SpeakAsync("I am Jarvis. Just A Rather Very Intelligent System");
                    break;

                case "What can you do?":
                    AI.Items.Add("Jarvis: I can open links, open application, say date and other");
                    Jarvis.SpeakAsync("I can open links, open application, say date and other");
                    break;

                case "What is my name?":
                    var user = Context.User.FirstOrDefault(u => u.Id == 1);
                    AI.Items.Add($"Jarvis: Your name is {user!.Name}");
                    Jarvis.SpeakAsync($"Your name is {user!.Name}");
                    break;

                case "Say date":
                    AI.Items.Add($"Jarvis: {DateTime.Now:d}");
                    Jarvis.SpeakAsync(DateTime.Now.ToString("d"));
                    break;

                case "Say time":
                    AI.Items.Add($"Jarvis: {DateTime.Now:hh:mm}");
                    Jarvis.SpeakAsync(DateTime.Now.ToString("hh mm tt"));
                    break;

                case "Say day":
                    AI.Items.Add($"Jarvis: {DateTime.Now.DayOfWeek}");
                    Jarvis.SpeakAsync(DateTime.Now.DayOfWeek.ToString());
                    break;

                case "Show commands":
                    AI.Items.Clear();
                    Jarvis.SpeakAsync("No problem");

                    var commands = Context.Commands
                        .Select(c => c.Command)
                        .ToArray();

                    foreach (var choice in commands)
                    {
                        AI.Items.Add($"{choice}");
                    }
                    break;

                case "Hide commands":
                    AI.Items.Clear();
                    AI.Items.Add("Jarvis: Commands were hide");
                    Jarvis.SpeakAsync("Commands were hide");
                    break;

                case "Mute":
                    Jarvis.Volume = 0;
                    break;

                case "Unmute":
                    Jarvis.Volume = 100;
                    break;

                case "Sleep":
                    AI.Items.Clear();
                    I.Items.Clear();
                    Jarvis.SpeakAsync("Good bye sir");
                    Sir.RecognizeAsyncCancel();
                    StartListening.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "Clear":
                    AI.Items.Clear();
                    I.Items.Clear();
                    Jarvis.SpeakAsync("Completed");
                    break;
                    
                case "Navi":
                    AI.Items.Add("Jarvis: OK");
                    Jarvis.SpeakAsync("OK");
                    Process.Start("https://navi.gg/en/matches");
                    break;

                case "Naruto":
                    AI.Items.Add("Jarvis: OK");
                    Jarvis.SpeakAsync("OK");
                    Process.Start("https://jut.su/naruuto");
                    break;

                case "Google":
                    AI.Items.Add("Jarvis: OK");
                    Jarvis.SpeakAsync("OK");
                    Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
                    break;

                case "Youtube":
                    AI.Items.Add("Jarvis: OK");
                    Jarvis.SpeakAsync("OK");
                    Process.Start("https://www.youtube.com");
                    break;

                case "Instagram":
                    AI.Items.Add("Jarvis: OK");
                    Jarvis.SpeakAsync("OK");
                    Process.Start("https://www.instagram.com/?hl=ru");
                    break;

                case "Jira":
                    AI.Items.Add("Jarvis: OK");
                    Jarvis.SpeakAsync("OK");
                    Process.Start("https://wodcatclone.atlassian.net/jira/software/projects/WOD/boards/1");
                    break;

                case "GitHub":
                    AI.Items.Add("Jarvis: OK");
                    Jarvis.SpeakAsync("OK");
                    Process.Start("https://github.com/");
                    break;

                case "Telegram":
                    AI.Items.Add("Jarvis: OK");
                    Jarvis.SpeakAsync("OK");
                    Process.Start("https://web.telegram.org/z/");
                    break;

                case "Visual Studio":
                    AI.Items.Add("Jarvis: OK");
                    Jarvis.SpeakAsync("OK");
                    Process.Start(@"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe");
                    break;

                case "SQL":
                    AI.Items.Add("Jarvis: OK");
                    Jarvis.SpeakAsync("OK");
                    Process.Start(@"C:\Program Files (x86)\Microsoft SQL Server Management Studio 18\Common7\IDE\Ssms.exe");
                    break;

                case "Close":
                    Close();
                    break;
            }
        }

        private void StartListening_SpeechRecognized(object? sender, SpeechRecognizedEventArgs e)
        {
            var speech = e.Result.Text;

            if (!speech.Equals("Wake up")) return;

            StartListening.RecognizeAsyncCancel();
            AI.Items.Add("Waiting for instructions sir");
            Jarvis.SpeakAsync("Waiting for instructions sir");
            Sir.RecognizeAsync(RecognizeMode.Multiple);
        }

        private Grammar GetGrammar()
        {
            var commands = Context.Commands
                .Select(c => c.Command)
                .ToArray();
            
            var choices = new Choices(commands);

            var grammarBuilder = new GrammarBuilder(choices)
            {
                Culture = new CultureInfo("en-US")
            };

            return new Grammar(grammarBuilder);
        }
    }
}
