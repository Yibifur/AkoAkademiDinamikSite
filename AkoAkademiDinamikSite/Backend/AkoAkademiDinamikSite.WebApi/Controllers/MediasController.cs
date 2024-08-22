using AkoAkademiDinamikSite.BusinessLayer.Abstract;
using AkoAkademiDinamikSite.DtoLayer.Dtos.MediaDtos;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkoAkademiDinamikSite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediasController : ControllerBase
    {
        private readonly IMediaService MediaService;

        public MediasController(IMediaService MediaService)
        {
            this.MediaService = MediaService;
        }
        [HttpGet]
        public IActionResult GetAllMedias()
        {

            var entities = MediaService.TGetAll();
            return Ok(entities);

        }
        [HttpGet("{id}")]
        public IActionResult GetMediaById(int id)
        {

            var entity = MediaService.TGetById(id);
            return Ok(entity);

        }
        [HttpPost]
        public IActionResult CreateMedia(CreateMediaDto model)
        {
            Media Media = new Media()
            {
                FilePath = model.FilePath,
                FileType = model.FileType,
                UploadedDate = model.UploadedDate
            };

            MediaService.TInsert(Media);
            return Ok("sayfa eklendi");

        }
        [HttpPut]
        public IActionResult UpdateMedia(UpdateMediaDto model)
        {
            Media Media = new Media()
            {
                MediaId = model.MediaId,
                FilePath = model.FilePath,
                FileType = model.FileType,
                UploadedDate = model.UploadedDate
            };

            MediaService.TUpdate(Media);
            return Ok("sayfa eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteMedia(int id)
        {
            MediaService.TDelete(id);
            return Ok("Sayfa silindi");

        }
    }
}
