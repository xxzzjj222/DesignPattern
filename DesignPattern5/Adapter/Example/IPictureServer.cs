using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.Adapter.Example
{
    interface IPictureServer
    {
        public void UploadPicture(string pictureType, string pictureName);
    }
}
