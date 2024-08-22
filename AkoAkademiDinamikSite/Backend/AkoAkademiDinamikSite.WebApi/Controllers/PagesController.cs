using AkoAkademiDinamikSite.BusinessLayer.Abstract;
using AkoAkademiDinamikSite.DtoLayer.Dtos.PageDtos;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkoAkademiDinamikSite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : ControllerBase
    {
        private readonly IPageService pageService;

        public PagesController(IPageService pageService)
        {
            this.pageService = pageService;
        }
        [HttpGet]
        public IActionResult GetAllPages() {

            var entities = pageService.TGetAll();
            return Ok(entities);
        
        }
        [HttpGet("{id}")]
        public IActionResult GetPageById(int id)
        {

            var entity = pageService.TGetById(id);
            return Ok(entity);

        }
        [HttpPost]
        public IActionResult CreatePage(CreatePageDto model)
        {
            Page page = new Page()
            {
                ParentPageId = model.ParentPageId,
                ContentId = model.ContentId,
                MenuOrder = model.MenuOrder
            };
            
            pageService.TInsert(page);
            return Ok("sayfa eklendi");

        }
        [HttpPut]
        public IActionResult UpdatePage(UpdatePageDto model)
        {
            Page page = new Page()
            {
                PageId = model.PageId,
                ParentPageId = model.ParentPageId,
                ContentId = model.ContentId,
                MenuOrder = model.MenuOrder
            };

            pageService.TUpdate(page);
            return Ok("sayfa eklendi");

        }
        [HttpDelete]
        public IActionResult DeletePage(int id)
        {
            pageService.TDelete(id);
            return Ok("Sayfa silindi");

        }

    }
}
