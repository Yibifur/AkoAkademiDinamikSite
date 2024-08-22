using AkoAkademiDinamikSite.BusinessLayer.Abstract;
using AkoAkademiDinamikSite.DtoLayer.Dtos.ContentDtos;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkoAkademiDinamikSite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentsController : ControllerBase
    {
        private readonly IContentService ContentService;

        public ContentsController(IContentService ContentService)
        {
            this.ContentService = ContentService;
        }
        [HttpGet]
        public IActionResult GetAllContents()
        {

            var entities = ContentService.TGetAll();
            return Ok(entities);

        }
        [HttpGet("{id}")]
        public IActionResult GetContentById(int id)
        {

            var entity = ContentService.TGetById(id);
            return Ok(entity);

        }
        [HttpPost]
        public IActionResult CreateContent(CreateContentDto model)
        {
            Content Content = new Content()
            {
                Title = model.Title,
                Slug= model.Slug,   
                Body=model.Body,
                Template=model.Template,
                CreatedDate=model.CreatedDate,
                UpdatedDate=model.UpdatedDate,
                IsPublished=model.IsPublished,
            };

            ContentService.TInsert(Content);
            return Ok("sayfa eklendi");

        }
        [HttpPut]
        public IActionResult UpdateContent(UpdateContentDto model)
        {
            Content Content = new Content()
            {
                ContentId=model.ContentId,  
                Title = model.Title,
                Slug = model.Slug,
                Body = model.Body,
                Template = model.Template,
                CreatedDate = model.CreatedDate,
                UpdatedDate = model.UpdatedDate,
                IsPublished = model.IsPublished,
            };

            ContentService.TUpdate(Content);
            return Ok("sayfa eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteContent(int id)
        {
            ContentService.TDelete(id);
            return Ok("Sayfa silindi");

        }
    }
}
