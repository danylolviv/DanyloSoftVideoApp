using System;
using System.Collections.Generic;
using System.Linq;
using DanyloSoft.VideoApplication.Core.Models;
using DanyloSoft.VideoApplication.Domain.IRepositories;

namespace DanyloSoft.VideoApplication.Infrastructure.DataAccess.Repositories
{
    public class VideoRepositoryInMemory : IVideoRepository
    {
        public VideoRepositoryInMemory()
        {
            PopulateDB();
        }
        
        private static List<Video> _listOfVideos = new List<Video>();
        private static int _runningID = 4;
        
        private void PopulateDB()
        {
            _listOfVideos.Add(new Video{Id = 1, VideoTittle = "Django free", VideoStoryline = "A whole lot of Tarrantino kills"});
            _listOfVideos.Add(new Video{Id = 2, VideoTittle = "2012", VideoStoryline = "World colapses"});
            _listOfVideos.Add(new Video{Id = 3, VideoTittle = "Once upon in a Hollywood", VideoStoryline = "Brad Pitt and Leo smashing the actor game"});
            _listOfVideos.Add(new Video{Id = 4, VideoTittle = "House of CArds", VideoStoryline = "Corrupt us gov. system."});
        }

        public Video CreateVideo(Video newVideo)
        {
            newVideo.Id = _runningID++;
            newVideo.ReleaseDate = DateTime.Now;
            _listOfVideos.Add(newVideo);
            return newVideo;
        }

        public List<Video> GetListVideos()
        {
            return _listOfVideos;
        }

        public void UpdateVideo(Video newVideo)
        {
            Video videoToUpdate = FindById(newVideo.Id);
            if (videoToUpdate != null)
            {
                videoToUpdate.VideoTittle = newVideo.VideoTittle;
                videoToUpdate.VideoStoryline = newVideo.VideoStoryline;
                videoToUpdate.ReleaseDate = newVideo.ReleaseDate;
                videoToUpdate.Id = newVideo.Id;    
            }
        }

        public void DeleteVideo(Video videoToDelete)
        {
            if (videoToDelete != null)
            {
                _listOfVideos.Remove(videoToDelete);    
            }
        }

        public Video FindById(int id)
        {
            foreach (var video in _listOfVideos)
            {
                if (video.Id == id)
                {
                    return video;
                }
            }
            return null;
        }
    }
}