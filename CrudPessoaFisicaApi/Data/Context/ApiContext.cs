using CrudPessoaFisicaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudPessoaFisicaApi.Data.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<PessoaFisica> PessoaFisica { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PessoaFisica>(f =>
            {
                f.ToTable("PessoaFisica");
                f.Property(x => x.NomeCompleto).IsRequired().HasMaxLength(200);
                f.Property(x => x.Cpf).IsRequired();
                f.Property(x => x.DataNascimento).IsRequired();


            });
        }

    }
}
