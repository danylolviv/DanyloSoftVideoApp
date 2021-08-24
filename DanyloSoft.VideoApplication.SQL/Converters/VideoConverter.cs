using DanyloSoft.VideoApplication.Core.Models;
using DanyloSoft.VideoApplication.SQL.Entities;

namespace DanyloSoft.VideoApplication.SQL.Converters
{
    public class VideoConverter
    {
        public Video Convert(VideoEntity entity)
        {
            return new Video
            {
                Id = entity.Id,
                ReleaseDate = entity.ReleaseDate,
                VideoStoryline = entity.VideoStoryline,
                VideoTittle = entity.VideoTittle
            };
        }
        
        public VideoEntity Convert(Video video)
        {
            return new VideoEntity
            {
                Id = video.Id,
                ReleaseDate = video.ReleaseDate,
                VideoStoryline = video.VideoStoryline,
                VideoTittle = video.VideoTittle,
                GenreId = video.Genre.Id
            };
        }
    }
}