using CrudPessoaFisicaApi.Application.IApplication;
using CrudPessoaFisicaApi.Domain.Entities;
using CrudPessoaFisicaApi.Domain.Validator;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;


namespace CrudPessoaFisicaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaFisicaController : ControllerBase
    {
        private readonly IPessoaFisicaApplication _pessoaFisicaApplication;
        public readonly PessoaFisicaValidator _validationRules = new PessoaFisicaValidator();
        public ValidationResult _result = new ValidationResult();

        public PessoaFisicaController(IPessoaFisicaApplication pessoaFisicaApplication)
        {
            _pessoaFisicaApplication = pessoaFisicaApplication;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_pessoaFisicaApplication.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] PessoaFisica pessoaFisica)
        {
            try
            {
                _result = _validationRules.Validate(pessoaFisica);
                if (_result.IsValid)
                {
                    return Ok(_pessoaFisicaApplication.Post(pessoaFisica));
                }
                return BadRequest(_result.Errors);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
