using CrudPessoaFisicaApi.Application.IApplication;
using CrudPessoaFisicaApi.Data.IRepository;
using CrudPessoaFisicaApi.Domain.Entities;

namespace CrudPessoaFisicaApi.Application
{
    public class PessoaFisicaApplication : IPessoaFisicaApplication
    {
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;
        public PessoaFisicaApplication(IPessoaFisicaRepository pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }
        public PessoaFisica Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<PessoaFisica> GetAll()
        {
            return _pessoaFisicaRepository.GetAll();
        }

        public bool Post(PessoaFisica pessoaFisica)
        {
            return _pessoaFisicaRepository.Post(pessoaFisica);
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
