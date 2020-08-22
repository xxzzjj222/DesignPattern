using DesignPattern5.Adapter.Example;
using DesignPattern5.Adapter.Example2;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.Adapter
{
    /// <summary>
    /// 1、两种方式
    ///   1.1 使用继承
    ///   1.2 使用组合
    /// </summary>
    class PictureServerAdpater : IPictureServer
    {
        private VideoUploadServer videoUploadServer;

        public PictureServerAdpater()
        {
            videoUploadServer = new VideoUploadServer();
        }
        public void UploadPicture(string pictureType, string pictureName)
        {
            videoUploadServer.UploadVideo(pictureName);
        }
    }
}
