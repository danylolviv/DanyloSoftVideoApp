using DanyloSoft.VideoApplication.Core.Models;

namespace DanyloSoft.VideoApplication.Domain.IRepositories
{
    public interface IVideoRepository
    {
        Video Add(Video video);
    }
}