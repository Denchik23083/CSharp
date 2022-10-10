using System;
using System.Globalization;
using System.IO;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TestAI
{
    public partial class MainForm : Form
    {
        public readonly SpeechRecognitionEngine Recognizer = new SpeechRecognitionEngine();
        public readonly SpeechRecognitionEngine StartListening = new SpeechRecognitionEngine();
        public SpeechSynthesizer Karen = new SpeechSynthesizer();
        public Random Rnd = new Random();
        public int RecTimeOut = 0;
        public DateTime TimeNow = DateTime.Now;

        public MainForm()
        {
            InitializeComponent();
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
            //int ranNum;

            var mySpeech = e.Result.Text;

            switch (mySpeech)
            {
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
                case "Close":
                    Close();
                    break;
            }
        }

        private void Recognizer_SpeechRecognition(object sender, SpeechDetectedEventArgs e)
        {

        }

        private void StartListening_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

        }

        private Grammar GetGrammar()
        {
            var choices = new Choices(File.ReadAllLines(@"Commands.txt"));

            var grammarBuilder = new GrammarBuilder(choices)
            {
                Culture = new CultureInfo("EN-US")
            };

            return new Grammar(grammarBuilder);
        }
    }
}
