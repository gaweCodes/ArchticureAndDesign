using System;

namespace TemplateMethod
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("--------- Video Player - MP4 video--------------");
            VideoPlayer fileExporter = new Mp4Player();
            fileExporter.PlayVideo();
            Console.WriteLine("----------------Video Player - MKV video---------------");
            fileExporter = new MkvPlayer();
            fileExporter.PlayVideo();
            Console.ReadLine();
        }
    }
}
