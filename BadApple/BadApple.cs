using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading;

namespace BadApple
{
    class BadApple
    {
        private string dataPath = "badapple.dat";
        private string musicPath = "BadApple.mp3";
        private string point = "@";
        private int width = 80;
        private int height = 30;
        private int wait = 55;
        private List<string> frames = new List<string>();

        private WaveStream blockAlignedStream;
        private WaveOut waveOut;

        private BadApple() { }

        public static BadApple Get()
        {
            return new BadApple();
        }

        public void Play()
        {
            try
            {
                InitConsole();
                LoadData();
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
                Console.WriteLine(str);
                Thread.Sleep(wait);
                Console.Clear();
            });
        }

        private void InitConsole()
        {
            //初始化控制台参数
            Console.Title = "BadAppleSharp";
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

        private void LoadData()
        {
            using (StreamReader reader = new StreamReader(new GZipStream(new FileStream(dataPath, FileMode.Open, FileAccess.Read), CompressionMode.Decompress)))
            {
                while (reader.Peek() >= 0)
                {
                    StringBuilder frame = new StringBuilder();
                    for(int i = 0; i < height; i++)
                    {
                        frame.Append(reader.ReadLine()).Append("\n");
                    }
                    frame = frame.Replace("#", point);
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
