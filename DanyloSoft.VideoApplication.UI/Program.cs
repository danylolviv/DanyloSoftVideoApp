using System;
using DanyloSoft.VideoApplication.Core.IServices;
using DanyloSoft.VideoApplication.Domain.IRepositories;
using DanyloSoft.VideoApplication.Domain.Services;
using DanyloSoft.VideoApplication.Infrastructure.DataAccess.Repositories;
using DanyloSoft.VideoApplication.SQL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleVideoLibraryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IVideoRepository, VideoRepositoryInMemory>();
            serviceCollection.AddScoped<IVideoService, VideoService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var mainMenu = new MainMenu(serviceProvider.GetRequiredService<IVideoService>());

            mainMenu.Start();
        }
    }
}