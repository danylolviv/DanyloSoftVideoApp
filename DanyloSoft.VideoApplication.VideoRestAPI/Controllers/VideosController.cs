using System;
using System.Collections.Generic;
using DanyloSoft.VideoApplication.Core.IServices;
using DanyloSoft.VideoApplication.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace DanyloSoft.VideoApplication.VideoRestAPI.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class VideosController : ControllerBase
  {
    private readonly IVideoService _videoservice;
    public VideosController(IVideoService videoService)
    {
      _videoservice = videoService;
    }
    
    // GET
    [HttpGet]
    public ActionResult<List<Video>> ReadAll()
    {
      return _videoservice.GetListVideos();
    }
    
    // GET by id
    [HttpGet("{id}")]
    public ActionResult<Video> ReadById(int id)
    {
      return _videoservice.GetVideoById(id);
    }
    //POST
    [HttpPost]
    public ActionResult<Video> CreateVideo([FromBody] Video newVideo)
    {
      if (string.IsNullOrEmpty(newVideo.VideoTittle))
      {
        return BadRequest("First name is required for creating new vid");
      }

      return StatusCode(550, "Who gut you smiling like this");
      //return _videoservice.CreateVideo(newVideo);
    }
    //PUT
    [HttpPut ("{id}")]
    public ActionResult<Video> UpdateVideo(int id, Video updatedVideo)
    {
      if (id < 1 || id != updatedVideo.Id)
      {
        return BadRequest("Customer id and id mush match.");
      }
      return _videoservice.UpdateVideo(updatedVideo);
    }
    //DELETE
    [HttpDelete("{id}")]
    public ActionResult<Video> DeleteVideo(int id, Video videoToDelete)
    {
      if (id != videoToDelete.Id)
      {
        return BadRequest("wrong access parameters");
      }
      var vid = _videoservice.DeleteVideo(videoToDelete);
      if (vid == null)
      {
        return BadRequest("video not found ((:");
      }
      return Ok($"vid with id {vid.Id} was successfully deleted .");
    }
  }
}