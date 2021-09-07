using System;

namespace DanyloSoft.VideoApplication.Core.Models
{
    public class Video
    {
        public string VideoTittle { get; set; }
        public string VideoStoryline { get; set; }
        public int Id { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public override string ToString()
        {
            return $"{VideoTittle}, {VideoStoryline}";
        }
    }
    
}