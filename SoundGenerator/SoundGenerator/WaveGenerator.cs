using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundGenerator
{
    public enum WaveExampleType
    {
        ExampleSineWave = 0
    }

    public class WaveGenerator
    {
        public WaveHeader header;
        public WaveFormatChunk format;
        public WaveDataChunk data;

        public WaveGenerator(WaveExampleType type, double frequency)
        {
            //initialize
            header = new WaveHeader();
            format = new WaveFormatChunk();
            data = new WaveDataChunk();

            //set
            switch (type)
            {
                case WaveExampleType.ExampleSineWave:
                    uint samples = (format.dwSamplesPerSec * format.wChannels) * 5; //data
                    data.shortArray = new short[samples];
                    int amplitude = 32760;                                      //volume (out of 32760)
                    double freq = frequency;                                    //pitch in Hz
                    double t = (Math.PI * 2 * freq) / (format.dwSamplesPerSec * format.wChannels);
                    for (uint i = 0; i < samples - 1; i++)
                    {
                        for (int channels = 0; channels < format.wChannels; channels++)
                        {
                            data.shortArray[i + channels] = Convert.ToInt16(amplitude * Math.Sin(t * i));
                        }
                    }
                    data.dwChunkSize = (uint)(data.shortArray.Length * (format.wBitsPerSample / 8));
                    break;
            }
        }

        public void save(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(fileStream);
            writer.Write(header.sGroupID.ToCharArray());
            writer.Write(header.dwFileLength);
            writer.Write(header.sRiffType.ToCharArray());
            writer.Write(format.sChunkID.ToCharArray());
            writer.Write(format.dwChunkSize);
            writer.Write(format.wFormatTag);
            writer.Write(format.wChannels);
            writer.Write(format.dwSamplesPerSec);
            writer.Write(format.dwAvgBytesPerSec);
            writer.Write(format.wBlockAlign);
            writer.Write(format.wBitsPerSample);
            writer.Write(data.sChunkID.ToCharArray());
            writer.Write(data.dwChunkSize);
            foreach (short dataPoint in data.shortArray)
            {
                writer.Write(dataPoint);
            }
            writer.Seek(4, SeekOrigin.Begin);
            uint filesize = (uint)writer.BaseStream.Length;
            writer.Write(filesize - 8);
            writer.Close();
            fileStream.Close();
        }
    }
}
