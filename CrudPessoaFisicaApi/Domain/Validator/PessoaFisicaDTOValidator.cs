using CrudPessoaFisicaApi.Domain.DTO;
using FluentValidation;
using static CrudPessoaFisicaApi.Domain.Common.Constantes;
using static CrudPessoaFisicaApi.Domain.Common.DateTimeExtensions;

namespace CrudPessoaFisicaApi.Domain.Validator
{
    public class PessoaFisicaDTOValidator : AbstractValidator<PessoaFisicaDTO>
    {
        public PessoaFisicaDTOValidator()
        {
            RuleFor(x => x.NomeCompleto).NotNull().WithMessage(ERRO_CAMPO_NULL)
                .NotEmpty().WithMessage(ERRO_CAMPO_VAZIO)
                .MaximumLength(200).WithMessage("Tamanho maximo do nome é {MaxLength}");

            RuleFor(x => x.Cpf).NotNull().WithMessage(ERRO_CAMPO_NULL)
                .NotEmpty().WithMessage(ERRO_CAMPO_VAZIO);

            RuleFor(x => x.DataNascimento).Must(ValidaData).WithMessage(ERRO_DATA_INVALIDA);
        }
    }
}
