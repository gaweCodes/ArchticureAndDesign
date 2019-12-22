using System;

namespace TemplateMethod
{
    internal abstract class VideoPlayer
    {
        protected void LoadFile() => Console.WriteLine("Video File loaded");
        protected abstract void DecodeVideoFormat();
        protected void StartPlay() =>  Console.WriteLine("Video File starts playing");
        public void PlayVideo()
        {
            LoadFile();
            DecodeVideoFormat();
            StartPlay();
        }
    }
}
