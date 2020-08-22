using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.Adapter.Example
{
    class PictureServer : IPictureServer
    {
        private PictureServerAdpater pictureServerAdpater;

        public PictureServer()
        {
            pictureServerAdpater = new PictureServerAdpater();
        }
        public void UploadPicture(string pictureType, string pictureName)
        {
            if (pictureType.Equals("mp4"))
            {
                pictureServerAdpater.UploadPicture(pictureType, pictureName);
            }
            else
            {
                Console.WriteLine($"图片名称:{pictureName},图片类型：{pictureType}，上传成功");
            }
        }
    }
}
