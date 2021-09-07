using System.Collections.Generic;
using DanyloSoft.VideoApplication.Core.Models;

namespace DanyloSoft.VideoApplication.Domain.IRepositories
{
    public interface IVideoRepository
    {
        Video CreateVideo(Video newVideo);

        Video DeleteVideo(Video videoToDelete);

        List<Video> GetListVideos();

        Video UpdateVideo(Video newVideo);

        Video FindById(int id);
    }
}