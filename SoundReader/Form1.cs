using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextTest_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoButton_Click(object sender, EventArgs e)
        {
            WaveReader wav = new WaveReader(FilePath.Text);
            TextTest.Text = Convert.ToString(wav.calculateFrequency() + "Hz");
            label1.Text = Convert.ToString(wav.calculateOctave(wav.frequency));
            NoteLabel.Text = Convert.ToString(wav.calculateNote(wav.frequency, wav.octave));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
