using AkoAkademiDinamikSite.BusinessLayer.Abstract;
using AkoAkademiDinamikSite.DtoLayer.Dtos.FormElementDtos;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkoAkademiDinamikSite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormElementsController : ControllerBase
    {
        private readonly IFormElementService FormElementService;

        public FormElementsController(IFormElementService FormElementService)
        {
            this.FormElementService = FormElementService;
        }
        [HttpGet]
        public IActionResult GetAllFormElements()
        {

            var entities = FormElementService.TGetAll();
            return Ok(entities);

        }
        [HttpGet("{id}")]
        public IActionResult GetFormElementById(int id)
        {

            var entity = FormElementService.TGetById(id);
            return Ok(entity);

        }
        [HttpPost]
        public IActionResult CreateFormElement(CreateFormElementDto model)
        {
            FormElement FormElement = new FormElement()
            {
                ControlType = model.ControlType,
                FormId = model.FormId,
                IsRequired=model.IsRequired,
                Order = model.Order,
                Title = model.Title
                
            };

            FormElementService.TInsert(FormElement);
            return Ok(FormElement);

        }
        [HttpPut]
        public IActionResult UpdateFormElement(UpdateFormElementDto model)
        {
            FormElement FormElement = new FormElement()
            {
                FormElementId = model.FormId,
                ControlType = model.ControlType,
                FormId = model.FormId,
                IsRequired = model.IsRequired,
                Order = model.Order,
                Title = model.Title
            };

            FormElementService.TUpdate(FormElement);
            return Ok("sayfa eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteFormElement(int id)
        {
            FormElementService.TDelete(id);
            return Ok("Sayfa silindi");

        }
    }
}
