using System.Collections.Generic;
using DanyloSoft.VideoApplication.Core.IServices;
using DanyloSoft.VideoApplication.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace DanyloSoft.VideoApplication.VideoRestAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class VideosController : ControllerBase
  {
    private readonly IVideoService _videoservice;

    public VideosController(IVideoService videoService)
    {
      _videoservice = videoService;
    }
    
    // GET
    [HttpGet]
    public List<Video> ReadAll()
    {
      return _videoservice.GetListVideos();
    }
    //POST
    [HttpPost]
    public Video CreateVideo([FromBody] Video newVideo)
    {
      return _videoservice.CreateVideo(newVideo);
    }
    //PUT
    [HttpPut ("{id}")]
    public Video UpdateVideo(int id, Video updatedVideo)
    {
      return _videoservice.UpdateVideo(updatedVideo);
    }
    //DELETE
    [HttpDelete]
    public void DeleteVideo(Video videoToDelete)
    {
      _videoservice.DeleteVideo(videoToDelete);
    }
  }
}