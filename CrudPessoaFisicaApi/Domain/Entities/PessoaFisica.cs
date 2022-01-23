using CrudPessoaFisicaApi.Domain.DTO;

namespace CrudPessoaFisicaApi.Domain.Entities
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }
}
