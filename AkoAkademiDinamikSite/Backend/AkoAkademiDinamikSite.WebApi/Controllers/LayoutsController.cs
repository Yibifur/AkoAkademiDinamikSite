using AkoAkademiDinamikSite.BusinessLayer.Abstract;
using AkoAkademiDinamikSite.DtoLayer.Dtos.LayoutDtos;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkoAkademiDinamikSite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LayoutsController : ControllerBase
    {
        private readonly ILayoutService LayoutService;

        public LayoutsController(ILayoutService LayoutService)
        {
            this.LayoutService = LayoutService;
        }
        [HttpGet]
        public IActionResult GetAllLayouts()
        {

            var entities = LayoutService.TGetAll();
            return Ok(entities);

        }
        [HttpGet("{id}")]
        public IActionResult GetLayoutById(int id)
        {

            var entity = LayoutService.TGetById(id);
            return Ok(entity);

        }
        [HttpPost]
        public IActionResult CreateLayout(CreateLayoutDto model)
        {
            Layout Layout = new Layout()
            {
                Title = model.Title,
                FooterPartial = model.FooterPartial,
                HeaderPartial = model.HeaderPartial,
                HeadPartial = model.HeadPartial,
                ScriptPartial = model.ScriptPartial
            };

            LayoutService.TInsert(Layout);
            return Ok("sayfa eklendi");

        }
        [HttpPut]
        public IActionResult UpdateLayout(UpdateLayoutDto model)
        {
            Layout layout = new Layout()
            {
                LayoutId=model.LayoutId,
                Title = model.Title,
                FooterPartial=model.FooterPartial,
                HeaderPartial=model.HeaderPartial,
                HeadPartial=model.HeadPartial,
                ScriptPartial=model.ScriptPartial
            };

            LayoutService.TUpdate(layout);
            return Ok("sayfa eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteLayout(int id)
        {
            LayoutService.TDelete(id);
            return Ok("Sayfa silindi");

        }
    }
}
