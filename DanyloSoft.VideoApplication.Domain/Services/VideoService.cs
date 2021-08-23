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
        public Video Create(Video video)
        {
            return _repo.Add(video);
        }
    }
}