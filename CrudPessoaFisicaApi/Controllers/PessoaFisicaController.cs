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
        private readonly PessoaFisicaValidator _validationRules = new PessoaFisicaValidator();
        private ValidationResult _result = new ValidationResult();

        public PessoaFisicaController(IPessoaFisicaApplication pessoaFisicaApplication)
        {
            _pessoaFisicaApplication = pessoaFisicaApplication;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_pessoaFisicaApplication.Get(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_pessoaFisicaApplication.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
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

        [HttpPut]
        public IActionResult Put([FromBody] PessoaFisica pessoaFisica)
        {
            try
            {
                _result = _validationRules.Validate(pessoaFisica);
                if (_result.IsValid)
                {
                    return Ok(_pessoaFisicaApplication.Put(pessoaFisica));
                }
                return BadRequest(_result.Errors);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(_pessoaFisicaApplication.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
