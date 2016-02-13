using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = PATH.Text;
            double hertz = Convert.ToDouble(HertzValue.Text);
            WaveGenerator waveGenerator = new WaveGenerator(WaveExampleType.ExampleSineWave, hertz);
            waveGenerator.save(filePath);
            SoundPlayer soundPlayer = new SoundPlayer(filePath);
            soundPlayer.Play();
        }

        private void PathLabel_Click(object sender, EventArgs e)
        {

        }

        private void HertzSlider_Scroll(object sender, EventArgs e)
        {
            HertzValue.Text = Convert.ToString(HertzSlider.Value);
        }
    }
}