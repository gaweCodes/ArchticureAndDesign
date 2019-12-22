using System;

namespace TemplateMethod
{
    internal class Mp4Player : VideoPlayer
    {
        protected override void DecodeVideoFormat() => Console.WriteLine("Video file is processed with MP4 Decoder");
    }
}
