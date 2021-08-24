using System;
using DanyloSoft.VideoApplication.Core.Models;

namespace DanyloSoft.VideoApplication.SQL.Entities
{
    public class VideoEntity
    {
        public string VideoTittle { get; set; }
        public string VideoStoryline { get; set; }
        public int Id { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreId { get; set; }
    }
}