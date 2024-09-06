using AkoAkademiDinamikSite.BusinessLayer.Abstract;
using AkoAkademiDinamikSite.DtoLayer.Dtos.FormOptionDtos;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkoAkademiDinamikSite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormOptionsController : ControllerBase
    {
        private readonly IFormOptionService FormOptionService;

        public FormOptionsController(IFormOptionService FormOptionService)
        {
            this.FormOptionService = FormOptionService;
        }
        [HttpGet]
        public IActionResult GetAllFormOptions()
        {

            var entities = FormOptionService.TGetAll();
            return Ok(entities);

        }
        [HttpGet("ByFormElementId/{id}")]
        public IActionResult GetAllFormOptionsByFormElementId(int id)
        {
            var entities = FormOptionService.TGetFormOptionsByFormElementId(id);
            return Ok(entities);
        }
        [HttpGet("{id}")]
        public IActionResult GetFormOptionById(int id)
        {

            var entity = FormOptionService.TGetById(id);
            return Ok(entity);

        }
        [HttpPost]
        public IActionResult CreateFormOption(CreateFormOptionDto model)
        {
            FormOption FormOption = new FormOption()
            {
                FormElementId = model.FormElementId,
                Name = model.Name,  
                Value = model.Value,
                Order = model.Order,
                IsSelected = model.IsSelected  
            };

            FormOptionService.TInsert(FormOption);
            return Ok("sayfa eklendi");

        }
        [HttpPut]
        public IActionResult UpdateFormOption(UpdateFormOptionDto model)
        {
            FormOption FormOption = new FormOption()
            {
                FormElementId = model.FormElementId,
                FormOptionId = model.FormOptionId,
                Name = model.Name,
                Value = model.Value,
                Order = model.Order,
                IsSelected = model.IsSelected
            };

            FormOptionService.TUpdate(FormOption);
            return Ok("sayfa eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteFormOption(int id)
        {
            FormOptionService.TDelete(id);
            return Ok("Sayfa silindi");

        }
    }
}
