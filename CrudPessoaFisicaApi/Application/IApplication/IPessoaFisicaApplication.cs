using CrudPessoaFisicaApi.Domain.Entities;

namespace CrudPessoaFisicaApi.Application.IApplication
{
    public interface IPessoaFisicaApplication
    {
        PessoaFisica Get(int id);

        List<PessoaFisica> GetAll();

        bool Post(PessoaFisica pessoaFisica);

        bool Put(PessoaFisica pessoaFisica);

        bool Delete(int id);
    }
}
