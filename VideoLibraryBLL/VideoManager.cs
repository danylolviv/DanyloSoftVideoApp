using System;
using System.Collections.Generic;
using System.Linq;
using VideoLibraryModels;

namespace VideoLibraryBLL
{
    public class VideoManager
    {
        private static List<Video> _listOfVideos = new List<Video>();
        private static int _runningId = 5;
        
        public void PopulateDB()
        {
            _listOfVideos.Add(new Video{Id = 1, VideoTittle = "Django free", VideoStoryline = "A whole lot of Tarrantino kills"});
            _listOfVideos.Add(new Video{Id = 2, VideoTittle = "2012", VideoStoryline = "World colapses"});
            _listOfVideos.Add(new Video{Id = 3, VideoTittle = "Once upon in a Hollywood", VideoStoryline = "Brad Pitt and Leo smashing the actor game"});
            _listOfVideos.Add(new Video{Id = 4, VideoTittle = "House of CArds", VideoStoryline = "Corrupt us gov. system."});
        }

        public Video CreateVideo(Video newVideo)
        {
            newVideo.Id = _runningId++;
            newVideo.ReleaseDate = DateTime.Now;
            _listOfVideos.Add(newVideo);
            return newVideo;
        }

        public void DeleteVideo(Video videoToDelete)
        {
            _listOfVideos.Remove(videoToDelete);
        }

        public List<Video> GetListVideos()
        {
            return _listOfVideos;
        }

        public void UpdateVideo(Video newVideo)
        {
            foreach (var videoInArr in _listOfVideos.ToList())
            {
                if(videoInArr.Id == newVideo.Id)
                {
                    videoInArr.VideoTittle = newVideo.VideoTittle;
                    videoInArr.VideoStoryline = newVideo.VideoStoryline;
                    videoInArr.ReleaseDate = newVideo.ReleaseDate;
                    videoInArr.Id = newVideo.Id;
                    break;
                }
            }
            //Console.WriteLine("..::: Successfully updated!!! :::..");
        }
    }
}