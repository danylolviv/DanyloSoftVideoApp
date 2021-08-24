using System.Collections.Generic;
using DanyloSoft.VideoApplication.Core.IServices;
using DanyloSoft.VideoApplication.Core.Models;
using DanyloSoft.VideoApplication.Domain.IRepositories;

namespace DanyloSoft.VideoApplication.Domain.Services
{
    public class VideoService : IVideoService
    {
        private IVideoRepository _repo;

        public VideoService(IVideoRepository repo)
        {
            _repo = repo;
        }

        public Video CreateVideo(Video newVideo)
        {
            return _repo.CreateVideo(newVideo);
        }

        public void DeleteVideo(Video videoToDelete)
        {
            _repo.DeleteVideo(videoToDelete);
        }

        public List<Video> GetListVideos()
        {
            return _repo.GetListVideos();
        }

        public void UpdateVideo(Video newVideo)
        {
            _repo.UpdateVideo(newVideo);
        }
    }
}