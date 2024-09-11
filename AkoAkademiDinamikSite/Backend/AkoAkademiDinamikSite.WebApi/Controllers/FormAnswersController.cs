using AkoAkademiDinamikSite.BusinessLayer.Abstract;
using AkoAkademiDinamikSite.DtoLayer.Dtos.FormAnswerDtos;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkoAkademiDinamikSite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormAnswersController : ControllerBase
    {
        private readonly IFormAnswerService FormAnswerService;

        public FormAnswersController(IFormAnswerService FormAnswerService)
        {
            this.FormAnswerService = FormAnswerService;
        }
        [HttpGet]
        public IActionResult GetAllFormAnswers()
        {

            var entities = FormAnswerService.TGetAll();
            return Ok(entities);

        }
        [HttpGet("{id}")]
        public IActionResult GetFormAnswerById(int id)
        {

            var entity = FormAnswerService.TGetById(id);
            return Ok(entity);

        }
        [HttpPost]
        public IActionResult CreateFormAnswer(CreateFormAnswerDto model)
        {
            FormAnswer FormAnswer = new FormAnswer()
            {
                FormElementId = model.FormElementId,
                FormId = model.FormId,
                Value = model.Value
                
            };

            FormAnswerService.TInsert(FormAnswer);
            return Ok("sayfa eklendi");

        }
        [HttpPut]
        public IActionResult UpdateFormAnswer(UpdateFormAnswerDto model)
        {
            FormAnswer FormAnswer = new FormAnswer()
            {
                FormAnswerId=model.FormAnswerId,
                FormElementId = model.FormElementId,
                FormId = model.FormId,
                Value = model.Value
            };

            FormAnswerService.TUpdate(FormAnswer);
            return Ok("sayfa eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteFormAnswer(int id)
        {
            FormAnswerService.TDelete(id);
            return Ok("Sayfa silindi");

        }
    }
}
