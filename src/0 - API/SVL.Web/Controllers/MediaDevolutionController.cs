using Microsoft.AspNetCore.Mvc;
using SVL.Domain.Devolution;
using System;

namespace SVL.Web.Controllers
{
    [Route("api/MediaDevolution")]
    [ApiController]
    public class MediaDevolutionController : ControllerBase
    {
        
    }
}

/*
private IMediaDevolutionService<MediaDevolution> _mediaDvolutionServices;

        public MediaDevolutionController(IMediaDevolutionService<MediaDevolution> mediaDevolutionServices)
        {
            this._mediaDvolutionServices = mediaDevolutionServices;
        }

         GET: api/Media
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(_mediaDvolutionServices.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

         GET: api/Default/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(_mediaDvolutionServices.Get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


         POST: api/Default
        [HttpPost]
        public IActionResult Post([FromBody] MediaDto mediaDto)
        {
            try
            {
                Media media = new MediaBuilder().Build(mediaDto);
                _mediaDvolutionServices.Post<MediaValidator>(media);

                return new ObjectResult(media.ID);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

 
     */
