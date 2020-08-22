using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.Adapter.Example2
{
    class VideoUploadServer
    {
        /// <summary>
        /// 上传视频
        /// </summary>
        /// <param name="videoName"></param>
        public void UploadVideo(string videoName)
        {
            Console.WriteLine($"视频名称:{videoName}，上传成功");
        }
    }
}
