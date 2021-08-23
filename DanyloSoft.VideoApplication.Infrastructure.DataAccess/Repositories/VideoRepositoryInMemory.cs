using System.Collections.Generic;
using DanyloSoft.VideoApplication.Core.Models;
using DanyloSoft.VideoApplication.Domain.IRepositories;

namespace DanyloSoft.VideoApplication.Infrastructure.DataAccess.Repositories
{
    public class VideoRepositoryInMemory : IVideoRepository
    {
        private static List<Video> _videoTable = new List<Video>();
        private static int _runningID = 4;
        public Video Add(Video video)
        {
            video.Id = _runningID++;
            _videoTable.Add(video);
            return video;
        }
    }
}