using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter2.Prototype.Download
{
    public class GreenWaterDownload : IDownload
    {
        public void DownloadVideo(Video video)
        {
            Console.WriteLine($"{video.Content}");
            Console.WriteLine("视频上添加绿色水印");
        }
    }
}
