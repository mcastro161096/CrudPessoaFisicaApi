using CrudPessoaFisicaApi.Data.Context;
using CrudPessoaFisicaApi.Data.IRepository;
using CrudPessoaFisicaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;

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
            return _context.PessoaFisica.ToList();
        }

        public bool Post(PessoaFisica pessoaFisica)
        {
            IDbContextTransaction transaction = _context.Database.BeginTransaction();
            {
                try
                {
                   _context.PessoaFisica.Add(pessoaFisica);
                    _context.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {

                    transaction.Rollback();
                    throw;
                }
            }
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
