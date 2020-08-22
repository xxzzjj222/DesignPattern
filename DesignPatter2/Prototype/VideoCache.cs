using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter2.Prototype
{
    class VideoCache
    {
        private static Dictionary<string, Video> videoMap = new Dictionary<string, Video>();

        public static Video GetVideo(string videoId)
        {
            Video cachedVideo = videoMap[videoId];
            return (Video)cachedVideo.Clone();
        }

        public static void LoadCache()
        {
            Video video = new Video();
            video.Id = "1";
            video.Content = "战狼2";
            videoMap.Add(video.Id, video);

            //Video video1 = new Video();
            //video1.Id = "2";
            //video1.Content = "英雄本色";
            //videoMap.Add(video1.Id, video1);
        }
    }
}
