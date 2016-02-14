using SoundReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WaveMixr
{
    public class Main
    {

        public Main(Form1 form, string filePath)
        {
            WaveReader reader = new WaveReader(filePath);
            form.updateContents(reader);
            SoundPlayer player = new SoundPlayer(filePath);
            player.Play();
        }
    }
}
