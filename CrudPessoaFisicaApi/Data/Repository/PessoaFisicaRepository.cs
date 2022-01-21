using CrudPessoaFisicaApi.Data.Context;
using CrudPessoaFisicaApi.Data.IRepository;
using CrudPessoaFisicaApi.Domain.Entities;

namespace CrudPessoaFisicaApi.Data.Repository
{
    public class PessoaFisicaRepository : BaseRepository, IPessoaFisicaRepository
    {
        public PessoaFisicaRepository(ApiContext context) : base(context)
        {
        }

        public PessoaFisica Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<PessoaFisica> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Post(PessoaFisica pessoaFisica)
        {
            throw new NotImplementedException();
        }

        public bool Put(PessoaFisica pessoaFisica)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
