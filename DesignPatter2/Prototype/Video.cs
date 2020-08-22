using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DesignPatter2.Prototype
{
    [Serializable]
    public class Video : ICloneable
    {
        public string Id { get; set; }

        public string Content { get; set; }
        public object Clone()
        {
            //1.浅拷贝
            object clone = this.MemberwiseClone();
            return clone;

            ////2.深拷贝
            //MemoryStream memoryStream = new MemoryStream();
            //BinaryFormatter binaryFormatter = new BinaryFormatter();
            //binaryFormatter.Serialize(memoryStream, this);

            ////3.设置读取流的位置
            //memoryStream.Position = 0;

            //return binaryFormatter.Deserialize(memoryStream);

        }
    }
}
