using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoundReader
{
    class WaveReader
    {

        private string[] notes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        public short[] data;
        public int chunkID;
        public int fileSize;
        public int riffType;
        public int fmtID;
        public int fmtSize;
        public int fmtCode;
        public int channels;
        public int sampleRate;
        public int fmtAvgBPS;
        public int fmtBlockAlign;
        public int bitDepth;
        public int fmtExtraSize;
        public int dataID;
        public int dataSize;
        public FileInfo fileInf;
        public double frequency;
        public int octave;

        public WaveReader(string filePath)
        {
            fileInf = new FileInfo(filePath);
            FileStream waveFileStream = File.OpenRead(filePath);
            BinaryReader reader = new BinaryReader(waveFileStream);

            chunkID = reader.ReadInt32();
            fileSize = reader.ReadInt32();
            riffType = reader.ReadInt32();
            fmtID = reader.ReadInt32();
            fmtSize = reader.ReadInt32();
            fmtCode = reader.ReadInt16();
            channels = reader.ReadInt16();
            sampleRate = reader.ReadInt32();
            fmtAvgBPS = reader.ReadInt32();
            fmtBlockAlign = reader.ReadInt16();
            bitDepth = reader.ReadInt16();

            if (fmtSize == 18)
            {
                // Read any extra values
                fmtExtraSize = reader.ReadInt16();
                reader.ReadBytes(fmtExtraSize);
            }

            dataID = reader.ReadInt32();
            dataSize = reader.ReadInt32();
            data = new short[dataSize / 2];
            for (int i = 0; i < dataSize / 2 - 1; i++)
            {
                data[i] = reader.ReadInt16();
            }

            reader.Close();
            waveFileStream.Close();
        }

        public double calculateFrequency()
        {
            int firstPeak = findFirstPeakIndex();
            frequency = 1.0 / (firstPeak * 4.0 / (sampleRate));
            return frequency;
        }

        public int findFirstPeakIndex()
        {
            for (int i = 1; i < data.Length - 1; i++)
            {
                if (data[i-1] < data[i] && data[i+1] < data[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public int calculateOctave(double frequency)
        {
            return (octave = (int)(Math.Log(frequency / 16.35, 2)));
        }

        public string calculateNote(double frequency, int octave)
        {
            frequency = frequency / (Math.Pow(2, octave));
            frequency -= 16.35;
            frequency = (int) (frequency / 1.19);
            return notes[(int) frequency];
        }
    }
}
