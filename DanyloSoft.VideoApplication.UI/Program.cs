using System;
using DanyloSoft.VideoApplication.Core.IServices;
using DanyloSoft.VideoApplication.Domain.IRepositories;
using DanyloSoft.VideoApplication.Domain.Services;
using DanyloSoft.VideoApplication.Infrastructure.DataAccess.Repositories;
using DanyloSoft.VideoApplication.SQL.Repositories;

namespace ConsoleVideoLibraryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IVideoRepository repo = new VideoRepositoryInMemory();
            IVideoService service = new VideoService(repo);
            var menu = new MainMenu(service);
            menu.Start();
        }
    }
}