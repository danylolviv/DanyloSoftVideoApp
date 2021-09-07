using System.Collections.Generic;
using DanyloSoft.VideoApplication.Core.Models;

namespace DanyloSoft.VideoApplication.Core.IServices
{
    public interface IVideoService
    {
        //POST request
        Video CreateVideo(Video newVideo);
        //DELETE request
        void DeleteVideo(Video videoToDelete);
        // GET request
        List<Video> GetListVideos();
        //PUT request
        Video UpdateVideo(Video newVideo);

    }
}