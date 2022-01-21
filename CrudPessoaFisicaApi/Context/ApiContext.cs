using Microsoft.EntityFrameworkCore;

namespace CrudPessoaFisicaApi.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
    }
}
