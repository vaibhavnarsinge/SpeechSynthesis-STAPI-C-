using System;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace SpeechSynthesis
{
    public partial class SpeechToText : Form
    {
        SpeechRecognitionEngine listner = new SpeechRecognitionEngine();
        public SpeechToText()
        {
            InitializeComponent();
        }

        //button for return to home page
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        //button for exit application
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Form
        private void SpeechToText_Load(object sender, EventArgs e)
        {
            listner.SetInputToDefaultAudioDevice();

           // listner.LoadGrammar(new DictationGrammar());
            listner.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices("hello", "welcome to my program", "thank you"))));
            listner.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

        }

        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            richTextBox1.Text = e.Result.Text ;
        }

        //button for speak
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            listner.RecognizeAsync(RecognizeMode.Multiple);
            guna2Button1.Enabled = false;
            guna2Button2.Enabled = true;
        }

        //button for stop
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            listner.RecognizeAsyncCancel();
            guna2Button1.Enabled = true;
            guna2Button2.Enabled = false;
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        
    }
}
