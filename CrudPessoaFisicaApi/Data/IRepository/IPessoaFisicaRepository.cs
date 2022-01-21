using CrudPessoaFisicaApi.Domain.Entities;

namespace CrudPessoaFisicaApi.Data.IRepository
{
    public interface IPessoaFisicaRepository
    {
        PessoaFisica Get(int id);

        List<PessoaFisica> GetAll();

        bool Post(PessoaFisica pessoaFisica);

        bool Put(PessoaFisica pessoaFisica);

        bool Delete(int id);
    }
}
