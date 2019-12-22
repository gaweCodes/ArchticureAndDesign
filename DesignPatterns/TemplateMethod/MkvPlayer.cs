using System;

namespace TemplateMethod
{
    internal class MkvPlayer : VideoPlayer
    {
        protected override void DecodeVideoFormat() => Console.WriteLine("Video file is processed with Mkv Decoder");
    }
}
