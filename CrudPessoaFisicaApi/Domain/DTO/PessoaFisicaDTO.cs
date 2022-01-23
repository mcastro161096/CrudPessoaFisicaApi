namespace CrudPessoaFisicaApi.Domain.DTO
{
    public class PessoaFisicaDTO
    {
        public string Cpf { get; set; }

        public string NomeCompleto { get; set; }

        public DateTime DataNascimento { get; set; }

        public string ValorRenda { get; set; }
    }
}
