using SoundReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaveMixr
{
    public partial class Form1 : Form
    {
        string[] files =
            {
                //use local wav files (from wav generator) (mono channel only)
                "C:/Users/Jared/Google Drive/Programming/SoundProject/2001/196Hz",
                "C:/Users/Jared/Google Drive/Programming/SoundProject/2001/293Hz",
                "C:/Users/Jared/Google Drive/Programming/SoundProject/2001/391Hz",
                "C:/Users/Jared/Google Drive/Programming/SoundProject/2001/494Hz",
                "C:/Users/Jared/Google Drive/Programming/SoundProject/2001/466Hz"
            };
        private int fileIndex = 0;

        public Form1()
        {
            InitializeComponent();

        }

        public void updateContents(WaveReader reader)
        {
            HertzLabel.Text = Convert.ToString((int) reader.frequency) + " Hz";
            OctaveNumber.Text = Convert.ToString(reader.octave);
            NoteLabel.Text = reader.note;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            new Main(this, files[fileIndex]);
            fileIndex++;
            fileIndex = fileIndex % files.Length;
        }

        private void NoteLabel_Click(object sender, EventArgs e)
        {

        }

        private void HertzLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
