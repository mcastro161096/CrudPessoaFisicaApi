using CrudPessoaFisicaApi.Domain.Entities;
using FluentValidation;

namespace CrudPessoaFisicaApi.Domain.Validator
{
    public class PessoaFisicaValidator : AbstractValidator<PessoaFisica>
    {
        const string ERRO_CAMPO_VAZIO = "Não pode ser vazio";
        const string ERRO_CAMPO_NULL = "Não pode ser nulo";
        const string ERRO_DATA_INVALIDA = " Data inválida";


        public PessoaFisicaValidator()
        {
            RuleFor(x => x.NomeCompleto).NotNull().WithMessage(ERRO_CAMPO_NULL)
                .NotEmpty().WithMessage(ERRO_CAMPO_VAZIO)
                .MaximumLength(200).WithMessage("Tamanho maximo do nome é {MaxLength}");

            RuleFor(x => x.Cpf).NotNull().WithMessage(ERRO_CAMPO_NULL)
                .NotEmpty().WithMessage(ERRO_CAMPO_VAZIO);

            RuleFor(x => x.DataNascimento).Must(ValidaData).WithMessage(ERRO_DATA_INVALIDA);
        }

        private bool ValidaData(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}
