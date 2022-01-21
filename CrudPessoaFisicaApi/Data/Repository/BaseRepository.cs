using CrudPessoaFisicaApi.Data.Context;

namespace CrudPessoaFisicaApi.Data.Repository
{
    public class BaseRepository
    {
        protected readonly ApiContext _context;

        public BaseRepository(ApiContext context)
        {
            _context = context;
        }
    }
}
