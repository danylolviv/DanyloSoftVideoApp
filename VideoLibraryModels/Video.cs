using System;

namespace VideoLibraryModels
{
    public class Video
    {
        public string VideoTittle { get; set; }
        public string VideoStoryline { get; set; }
        public int Id { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}