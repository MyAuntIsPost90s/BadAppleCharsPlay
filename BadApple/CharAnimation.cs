using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading;

namespace BadApple
{
    class CharAnimation
    {
        private string dataPath = "data.txt";
        private string musicPath = "data.mp3";
        private int width = 0;
        private int height = 0;
        private int wait = 48;
        private List<string> frames = new List<string>();

        private WaveStream blockAlignedStream;
        private WaveOut waveOut;

        private CharAnimation() { }

        public static CharAnimation Get()
        {
            return new CharAnimation();
        }

        public void Play()
        {
            try
            {
                LoadTxtData();
                InitConsole();
                LoadMusic();
                PlayAnimation();
            }
            finally
            {
                Dispose();
            }
            Console.ReadKey();
        }

        private void PlayAnimation()
        {
            waveOut.Play();
            frames.ForEach((str) =>
            {
                Console.Write(str);
                Thread.Sleep(wait);
                Console.Clear();
            });
        }

        private void InitConsole()
        {
            //初始化控制台参数
            Console.Title = "CharAnimation";
            Console.CursorVisible = false;
            Console.WindowWidth = width + 1; 
            Console.WindowHeight = height + 1;
        }

        private void LoadMusic()
        {
            blockAlignedStream = new BlockAlignReductionStream(WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(musicPath)));
            waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback());
            waveOut.Init(blockAlignedStream);
        }

        private void LoadTxtData()
        {
            string[] lines = File.ReadAllLines(dataPath);
            height = (lines.Length-1) / Convert.ToInt32(lines[0]);
            width = lines[1].Length;
            StringBuilder frame = new StringBuilder();
            for (int i = 1; i < lines.Length; i++)
            {
                frame.Append(lines[i]).Append("\n");
                if (i % height == 0 && i > 0)
                {
                    frames.Add(frame.ToString());
                    frame.Clear();
                }
            }
        }

        private void Dispose()
        {
            waveOut.Pause();
            waveOut.Dispose();
            blockAlignedStream.Close();
            blockAlignedStream.Dispose();
        }
    }
}
