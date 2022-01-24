using CrudPessoaFisicaApi.Application.IApplication;
using CrudPessoaFisicaApi.Data.IRepository;
using CrudPessoaFisicaApi.Domain.DTO;
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
            var pessoaFisica = _pessoaFisicaRepository.Get(id);
            if (pessoaFisica == null)
                pessoaFisica = new PessoaFisica();
            return pessoaFisica;
        }

        public List<PessoaFisica> GetAll()
        {
            var listapessoas = _pessoaFisicaRepository.GetAll();
            if (listapessoas == null)
                listapessoas = new List<PessoaFisica>();
            return listapessoas;
        }

        public bool Post(PessoaFisicaDTO pessoaFisicaDTO)
        {
            var novaPessoaFisica = new PessoaFisica()
            {
                NomeCompleto = pessoaFisicaDTO.NomeCompleto,
                Cpf = pessoaFisicaDTO.Cpf,
                ValorRenda = pessoaFisicaDTO.ValorRenda,
                DataNascimento = pessoaFisicaDTO.DataNascimento,
            };

            return _pessoaFisicaRepository.Post(novaPessoaFisica);
        }



        public bool Put(PessoaFisica pessoaFisica)
        {
            return _pessoaFisicaRepository.Put(pessoaFisica);
        }

        public bool Delete(int id)
        {
            return _pessoaFisicaRepository.Delete(id);
        }
    }
}
