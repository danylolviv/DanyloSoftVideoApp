using System.Collections.Generic;
using DanyloSoft.VideoApplication.Core.Models;
using DanyloSoft.VideoApplication.Domain.IRepositories;
using DanyloSoft.VideoApplication.SQL.Converters;
using DanyloSoft.VideoApplication.SQL.Entities;

namespace DanyloSoft.VideoApplication.SQL.Repositories
{
    public class VideoRepository : IVideoRepository
    {
        private static List<VideoEntity> _listVideoEntities = new List<VideoEntity>();
        private static int _runningId = 4;
        private static VideoConverter _videoConverter;

        public VideoRepository()
        {
            _videoConverter = new VideoConverter();
        }
        
        public Video CreateVideo(Video newVideo)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteVideo(Video videoToDelete)
        {
            throw new System.NotImplementedException();
        }

        public List<Video> GetListVideos()
        {
            var listOfVideos = new List<Video>();
            foreach (VideoEntity videoEntity in _listVideoEntities)
            {
                listOfVideos.Add(_videoConverter.Convert(videoEntity));
            }
            return listOfVideos;
        }

        public void UpdateVideo(Video newVideo)
        {
            throw new System.NotImplementedException();
        }

        public Video FindById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}