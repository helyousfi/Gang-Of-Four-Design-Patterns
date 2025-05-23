﻿using DesignPatterns.Structural.Proxy.BadExample.ThirdPartyVideoLib;

namespace DesignPatterns.Structural.Proxy.BadExample
{
    internal class VideoList
    {
        private Dictionary<string, Video> _videoList = new Dictionary<string, Video>();

        public void Add(Video video)
        {
            _videoList.Add(video.GetVideoId(), video);
        }


        public void Watch(string videoId)
        {
            var video = _videoList[videoId];
            video.Render();
        }
    }
}
