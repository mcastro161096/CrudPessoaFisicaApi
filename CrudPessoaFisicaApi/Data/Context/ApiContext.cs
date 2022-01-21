using Microsoft.EntityFrameworkCore;

namespace CrudPessoaFisicaApi.Data.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
    }
}
