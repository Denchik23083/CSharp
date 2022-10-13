using System;
using System.Globalization;
using System.IO;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;

namespace TestAI
{
    public partial class MainForm : Form
    {
        public SpeechRecognitionEngine Recognizer = new SpeechRecognitionEngine();
        public SpeechRecognitionEngine StartListening = new SpeechRecognitionEngine();
        public SpeechSynthesizer Karen = new SpeechSynthesizer();
        public Random Rnd = new Random();
        public int RecTimeOut;

        public MainForm()
        {
            InitializeComponent();
            
            Karen.SelectVoice("Microsoft Zira Desktop");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Recognizer.SetInputToDefaultAudioDevice();
            Recognizer.LoadGrammarAsync(GetGrammar());
            Recognizer.SpeechRecognized += Default_SpeechRecognition;
            Recognizer.SpeechDetected += Recognizer_SpeechRecognition;
            Recognizer.RecognizeAsync(RecognizeMode.Multiple);

            StartListening.SetInputToDefaultAudioDevice();
            StartListening.LoadGrammarAsync(GetGrammar());
            StartListening.SpeechRecognized += StartListening_SpeechRecognized;
        }

        private void Default_SpeechRecognition(object sender, SpeechRecognizedEventArgs e)
        {
            var mySpeech = e.Result.Text;

            switch (mySpeech)
            {
                case "Hello":
                    Karen.SpeakAsync("Hello, I am here");
                    break;

                case "How are you?":
                    Karen.SpeakAsync("I am working normally");
                    break;

                case "Who are you?":
                    Karen.SpeakAsync("I am Karen.");
                    break;

                case "What time is it?":
                    Karen.SpeakAsync(DateTime.Now.ToString("hh mm tt"));
                    break;

                case "What day is it?":
                    Karen.SpeakAsync(DateTime.Now.DayOfWeek.ToString());
                    break;

                case "Show commands":
                    Karen.SpeakAsync("OK");
                    var choices = File.ReadAllLines(@"Commands.txt");
                    foreach (var choice in choices)
                    {
                        ListCommands.Items.Add($"{choice}");
                    }
                    break;

                case "Hide commands":
                    Karen.SpeakAsync("OK");
                    ListCommands.Items.Clear();
                    break;

                case "Stop talking":
                    ListCommands.Items.Clear();
                    Karen.SpeakAsyncCancelAll();
                    var ranNum = Rnd.Next(1, 2);

                    switch (ranNum)
                    {
                        case 1:
                            Karen.SpeakAsync("Yes sir");
                            break;
                        case 2:
                            Karen.SpeakAsync("I am sorry. I will be quiet");
                            break;
                    }

                    break;

                case "Stop listening":
                    Karen.SpeakAsync("If you need me just ask");
                    Recognizer.RecognizeAsyncCancel();
                    StartListening.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "Close":
                    Close();
                    break;
            }
        }

        private void Recognizer_SpeechRecognition(object sender, SpeechDetectedEventArgs e)
        {
            RecTimeOut = 0;
        }

        private void StartListening_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            var speech = e.Result.Text;

            if (speech != "Wake up") return;

            StartListening.RecognizeAsyncCancel();
            Karen.SpeakAsync("Waiting for instructions sir");
            Recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private Grammar GetGrammar()
        {
            var choices = new Choices(File.ReadAllLines(@"Commands.txt"));

            var grammarBuilder = new GrammarBuilder(choices)
            {
                Culture = new CultureInfo("en-US")
            };

            return new Grammar(grammarBuilder);
        }

        private void TmrSpeaking_Tick(object sender, EventArgs e)
        {
            if (RecTimeOut == 10)
            {
                Recognizer.RecognizeAsyncCancel();
            }
            else if (RecTimeOut == 11)
            {
                TmrSpeaking.Stop();
                StartListening.RecognizeAsync(RecognizeMode.Multiple);
                RecTimeOut = 0;
            }
        }
    }
}
