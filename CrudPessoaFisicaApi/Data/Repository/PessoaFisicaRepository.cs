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
            return _context.PessoaFisica
                           .Where(x => x.Id == id)
                           .FirstOrDefault();
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
                    pessoaFisica.CreatedAt = DateTime.Now;
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
            IDbContextTransaction transaction = _context.Database.BeginTransaction();
            {
                try
                {
                    var pessoaFisicaEntity = _context.PessoaFisica.FirstOrDefault(p => p.Id == pessoaFisica.Id);

                    pessoaFisicaEntity.UpdatedAt = DateTime.Now;
                    pessoaFisicaEntity.Cpf = pessoaFisica.Cpf;
                    pessoaFisicaEntity.NomeCompleto = pessoaFisica.NomeCompleto;
                    pessoaFisicaEntity.ValorRenda = pessoaFisica.ValorRenda;
                    pessoaFisicaEntity.DataNascimento = pessoaFisica.DataNascimento;

                    _context.PessoaFisica.Update(pessoaFisicaEntity);
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

        public bool Delete(int id)
        {
            IDbContextTransaction transaction = _context.Database.BeginTransaction();
            {
                try
                {
                    var pessoaFisica = _context.PessoaFisica.FirstOrDefault(p => p.Id == id);
                    _context.PessoaFisica.Remove(pessoaFisica);
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
    }
}
