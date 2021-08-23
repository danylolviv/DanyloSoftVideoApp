namespace ConsoleVideoLibraryApplication
{
    public class StringConstants
    {
        public static readonly string WelcomeGreeting = "Welcome to the Video App";
        public static readonly string PleaseSelectMain = "Select One of the items below";
        public static readonly string CreateVideoMenuText = "Type 1 to Create new Video";
        public static readonly string ShowAllVideosMenuText = "Type 2 to See All available Videos";
        public const string PleaseSelectCorrectSearchOptions = "Please Select a nnumber between 0 and 2";
        public const string WhatToSearchFor = "Please Decide what to search for (1 - Id, 2 - Title, 0 - To Go Back)";
        public const string ExitMainMenuText = "Type 0 to Exit";
        public const string PleaseSelectCorrectItem = "Please Select a Number Between 0 and 5";
        public const string CreateVideoGreeting = "Create Video";
        public const string VideoStoryLine = "Type Video StoryLine (with more then 2 char and less then 240)";
        public const string VideoName = "Type Video Name (with more then 2 char and less then 40)";
        public static string EditVideos = "Type 3 to Edit selected video from the list";
        public static string DeleteVideos = "Type 4 To delete a video from the list";
        public static string SearchVideo = "Type 5 To search for video";
        public static string AllMOviesGreeting = "Here is the List of all movies in your library";
        public static string ExitAppText = "Thank you for using this service, you pressed 0, and application exited!";
        public static string Press0ToMainMenu = "Press 0 to go to Main Menu";

        public static string DeleteSelectedVideoGreeting =
            "Here is a list of Videos in Library, to delete video type its Id and press Enter.";

        public static string VideoDeleteError = "The id that you typed doesn't exist try different Id      Typed Id = ";
        public static string EditVideosGreeting = "Here is a list of Videos in Library, to edit video type its Id and press Enter.";
        public static string VideoEditProcess = "You chose to edit video with following title: ";
        public static string VideoEditing_NewTitle = "New Title:";
        public static string VideoEditing_NewStoryLine = "New StoryLine:";
        public static string SavingUpdatedVideo = "Following is how the new video will be saved, ..:: press 5 ::.. to save it";
        public static string SuccessfulUpdate = "You have successfully updated video, Congrats, have a beer";
        public static string SearchById = "Mode: search by Id initialized. Type Id";
        public static string SearchByTitle = "Mode: search by Title initialized. Type full title or part of it.";
        public static string VideoSearchWarning = "Wrong input, try typing a number!";
        public static string SearchResults = "Here are the results from your recent search. Press 1 to start over.";
    }
}