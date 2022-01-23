namespace CrudPessoaFisicaApi.Domain.Common
{
    public static class DateTimeExtensions
    {
        public static bool ValidaData(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}
