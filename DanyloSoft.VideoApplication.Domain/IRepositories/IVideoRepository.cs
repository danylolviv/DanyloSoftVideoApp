using System.Collections.Generic;
using DanyloSoft.VideoApplication.Core.Models;

namespace DanyloSoft.VideoApplication.Domain.IRepositories
{
    public interface IVideoRepository
    {
        Video CreateVideo(Video newVideo);

        void DeleteVideo(Video videoToDelete);

        List<Video> GetListVideos();

        void UpdateVideo(Video newVideo);

        Video FindById(int id);
    }
}