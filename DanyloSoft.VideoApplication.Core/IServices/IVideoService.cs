using System.Collections.Generic;
using DanyloSoft.VideoApplication.Core.Models;

namespace DanyloSoft.VideoApplication.Core.IServices
{
    public interface IVideoService
    {
        Video CreateVideo(Video newVideo);

        void DeleteVideo(Video videoToDelete);

        List<Video> GetListVideos();

        void UpdateVideo(Video newVideo);

    }
}