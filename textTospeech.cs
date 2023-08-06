using System;
using System.Speech.Synthesis; 
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpeechSynthesis
{
    public partial class textTospeech : Form
    {
        SpeechSynthesizer sapi = new SpeechSynthesizer();

        public textTospeech()
        {
            InitializeComponent();
        }

       
        //button for return to Home page
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (sapi.State == SynthesizerState.Speaking)
            {
                sapi.Pause();
            }

            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        //button for Exit Application
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //speak button
        private async void btnspeakt_Click(object sender, EventArgs e)
        {

            if (rtSpeakt.Text != "")
            {
                sapi.SpeakAsync(rtSpeakt.Text);

            }
            else
            {
                rtSpeakt.Text = "please enter some text to read";
                sapi.SpeakAsync(rtSpeakt.Text);

                await Task.Delay(2000);
                rtSpeakt.Clear();
                rtSpeakt.Focus();
            }
        }

        //pause button
        private void btnpauset_Click(object sender, EventArgs e)
        {
            if(sapi.State == SynthesizerState.Speaking)
            {
                sapi.Pause();
            }
        }

        //Resume button
        private void btnresumet_Click(object sender, EventArgs e)
        {
            if(sapi != null)
            {
                if (sapi.State == SynthesizerState.Paused)
                {
                    sapi.Resume();
                }
            }
        }

        private void rtSpeakt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textTospeech_Load(object sender, EventArgs e)
        {

        }
    }
}
