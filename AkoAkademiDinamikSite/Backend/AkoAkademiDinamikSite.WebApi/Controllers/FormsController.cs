using AkoAkademiDinamikSite.BusinessLayer.Abstract;
using AkoAkademiDinamikSite.DtoLayer.Dtos.FormDtos;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkoAkademiDinamikSite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormsController : ControllerBase
    {
        private readonly IFormService FormService;

        public FormsController(IFormService FormService)
        {
            this.FormService = FormService;
        }
        [HttpGet]
        public IActionResult GetAllForms()
        {

            var entities = FormService.TGetAll();
            return Ok(entities);

        }
        [HttpGet("GetDefaultForm")]
        public IActionResult GetDefaultForm()
        {

            var entities = FormService.TGetDefaultForm();
            return Ok(entities);

        }
        [HttpGet("{id}")]
        public IActionResult GetFormById(int id)
        {

            var entity = FormService.TGetById(id);
            return Ok(entity);

        }
        [HttpPost]
        public IActionResult CreateForm(CreateFormDto model)
        {
            Form Form = new Form()
            {
                Description = model.Description,
              FormType = model.FormType,
              ShowTitle = model.ShowTitle,
              Title = model.Title
            };

            FormService.TInsert(Form);
            return Ok("sayfa eklendi");

        }
        [HttpPut]
        public IActionResult UpdateForm(UpdateFormDto model)
        {
            Form Form = new Form()
            {
                FormId = model.FormId,
                Title = model.Title,
                ShowTitle=model.ShowTitle,
                Description = model.Description,    
                FormType=model.FormType
            };

            FormService.TUpdate(Form);
            return Ok("sayfa eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteForm(int id)
        {
            FormService.TDelete(id);
            return Ok("Sayfa silindi");

        }
    }
}
