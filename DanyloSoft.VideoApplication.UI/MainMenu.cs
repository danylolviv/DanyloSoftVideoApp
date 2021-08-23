using System;
using System.Collections.Generic;
using System.Linq;
using DanyloSoft.VideoApplication.Core.IServices;
using DanyloSoft.VideoApplication.Core.Models;
using VideoLibraryModels;
using VideoLibraryBLL;

namespace ConsoleVideoLibraryApplication
{
    public class MainMenu
    {
        private IVideoService _service;

        public MainMenu(IVideoService service)
        {
            _service = service;
        }
        public void Start()
        {
            StartMainMenu();
            ShowWelcomeGreeting();
        }
        
        private void StartMainMenu()
        {
            int choice;
            while ((choice = GetMainMenuSelection()) != 0)
            {
                
                switch (choice)
                {
                    case 1:
                        CreateVideo();
                        break;
                    case 2:
                        SeeMovieList();
                        break;
                    case 3:
                        UpdateVideo();
                        break;
                    case 4:
                        DeleteVideo();
                        break;
                    case 5:
                        SearchVideo();
                        break;
                    // case -1:
                    //     PleaseTryAgain();
                    //     break;
                }
            }
            Print(StringConstants.ExitAppText);
        }

        private void SearchVideo()
        {
            //Print(StringConstants.WhatToSearchFor);
            int choice;
            while ((choice = GetVideoSearchMenuSelection()) != 0)
            {
                switch (choice)
                {
                    case 1:
                        Print(StringConstants.SearchById);
                        int inputNum = 0;
                        while(inputNum == 0)
                        {
                            if (int.TryParse(Console.ReadLine(), out inputNum))
                            {
                                SearchById(inputNum);
                                break;
                            }
                            Print(StringConstants.VideoSearchWarning);
                        }
                        
                        break;
                    case 2:
                        Print(StringConstants.SearchByTitle);
                        string inputQuery = "0";
                        while(inputQuery.Contains("0"))
                        {
                            string userInput = Console.ReadLine();
                            if (!string.IsNullOrEmpty(userInput))
                            {
                                //inputQuery = userInput;
                                SearchByQuery(userInput);
                                break;
                            }
                            Print(StringConstants.VideoSearchWarning);
                        }
                        break;
                    case -1:
                        Print(StringConstants.PleaseSelectCorrectSearchOptions);
                        break;
                }
            }
        }
        
        private void SearchById(int id)
        {
            List<Video> searchResult = new List<Video>();
            
            foreach (var video in _videoManager.GetListVideos())
            {
                if (video.Id == id)
                {
                    Print($"{video.VideoTittle} {video.VideoStoryline} {video.Id}");
                }
            }
            
        }
        private void SearchByQuery(string searchQuery)
        {
            foreach (var video in _videoManager.GetListVideos())
            {
                if (video.VideoTittle.ToLower().Contains(searchQuery.ToLower()))
                {
                    Print($"{video.VideoTittle} {video.VideoStoryline} {video.Id}");
                }
                if (video.VideoStoryline.ToLower().Contains(searchQuery.ToLower()))
                {
                    Print($"{video.VideoTittle} {video.VideoStoryline} {video.Id}");
                }
            }
        }
        
        private int GetVideoSearchMenuSelection()
        {
            Print(StringConstants.WhatToSearchFor);
            var selectionString = Console.ReadLine();
            int selection;
            if (int.TryParse(selectionString, out selection))
            {
                return selection;
            }
            return -1;
        }

        private void UpdateVideo()
        {
            Print(StringConstants.EditVideosGreeting);
            Print("");
            foreach (var video in _videoManager.GetListVideos())
            {
                Print($"Title: {video.VideoTittle}  Storyline: {video.VideoStoryline}  Id: {video.Id}");
            }
            int chosenId = VideoIdSelection();
            while (chosenId != 0)
            {
                foreach (var video in _videoManager.GetListVideos().ToList())
                {
                    if (video.Id == chosenId)
                    {
                        Print($"{StringConstants.VideoEditProcess}{video.VideoTittle}");
                        
                        Print(StringConstants.VideoEditing_NewTitle);
                        var NewTitle = Console.ReadLine();
                        
                        Print((StringConstants.VideoEditing_NewStoryLine));
                        var NewStoryLine = Console.ReadLine();
                        
                        Video newVideo = new Video 
                        {
                            VideoTittle = NewTitle, 
                            VideoStoryline = NewStoryLine, 
                            Id = video.Id, 
                            ReleaseDate = DateTime.Now
                        };
                        Print(StringConstants.SavingUpdatedVideo);
                        
                        Print($"Title: {newVideo.VideoTittle}  Storyline: {newVideo.VideoStoryline}  Id: {newVideo.Id}");
                        
                        if (int.TryParse(Console.ReadLine(),out int inputSave))
                        {
                            Print(StringConstants.SuccessfulUpdate);
                            _videoManager.UpdateVideo(newVideo);
                        }
                        chosenId = 0;
                    }
                }
                if (chosenId == -1)
                {
                    Print($"{StringConstants.VideoDeleteError} {chosenId}");
                }
                
            }
            NextActionMainMenu();
        }

        private void DeleteVideo()
        {
            Print(StringConstants.DeleteSelectedVideoGreeting);
            Print("");
            foreach (var video in _videoManager.GetListVideos())
            {
                Print($"Title: {video.VideoTittle}  Storyline: {video.VideoStoryline}  Id: {video.Id}");
            }
            int chosenId = VideoIdSelection();
            while (chosenId != 0)
            {
                foreach (var video in _videoManager.GetListVideos().ToList())
                {
                    if (video.Id == chosenId)
                    {
                        _videoManager.DeleteVideo(video);
                        chosenId = 0;
                    }
                }
                if (chosenId == -1)
                {
                    Print($"{StringConstants.VideoDeleteError} {chosenId}");
                }
                
            }
            NextActionMainMenu();
        }

        private int VideoIdSelection()
        {
            PrintNewLine();
            var selectionString = Console.ReadLine();
            int selection;
            if (int.TryParse(selectionString, out selection))
            {
                return selection;
            }
            return -1;
        }

        private void SeeMovieList()
        {
            Print(StringConstants.AllMOviesGreeting);
            foreach (var video in _videoManager.GetListVideos())
            {
                Print($"Title: {video.VideoTittle}  Storyline: {video.VideoStoryline}  Id: {video.Id}");
            }
            NextActionMainMenu();
        }

        private void CreateVideo()
        {
           // Clear();
            Print(StringConstants.CreateVideoGreeting);
            Print(StringConstants.VideoName);
            var videoTitle = Console.ReadLine();
            Print(StringConstants.VideoStoryLine);
            var videoStoryLine = Console.ReadLine();
            //Call Service
            var video = new Video {VideoTittle = videoTitle, VideoStoryline = videoStoryLine};
            
            video = _videoManager.CreateVideo(video);
            Print($"Video With Following Properties Created - Id: {video.Id} Title: {video.VideoTittle} StoryLine: {video.VideoStoryline}");
            NextActionMainMenu();
        }

        private void NextActionMainMenu()
        {
            PrintNewLine();
            Print(StringConstants.Press0ToMainMenu);
            Console.ReadLine();
        }

        private int GetMainMenuSelection()
        {
            ShowMainMenu();
            PrintNewLine();
            var selectionString = Console.ReadLine();
            int selection;
            if (int.TryParse(selectionString, out selection))
            {
                return selection;
            }
            return -1;
        }

        private void ShowMainMenu()
        {
            Print(StringConstants.PleaseSelectMain);
            Print(StringConstants.CreateVideoMenuText);
            Print(StringConstants.ShowAllVideosMenuText);
            Print(StringConstants.EditVideos);
            Print(StringConstants.DeleteVideos);
            Print(StringConstants.SearchVideo);
            Print(StringConstants.ExitMainMenuText);
        }

        private static void ShowWelcomeGreeting()
        {
            Print(StringConstants.WelcomeGreeting);
        }

        private static void Print(string textToPrint)
        {
            Console.WriteLine(textToPrint);
        }

        private void PrintNewLine()
        {
            Console.WriteLine("");
        }

        private void Clear()
        {
            Console.Clear();
        }
    }
}