namespace CrudPessoaFisicaApi.Domain.Entities
{
    public abstract class Pessoa : EntityBase
    {
        public string NomeCompleto { get; set; }

        public DateTime DataNascimento { get; set; }

        public decimal ValorRenda { get; set; }
    }
}
