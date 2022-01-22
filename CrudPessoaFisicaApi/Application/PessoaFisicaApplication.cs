﻿using CrudPessoaFisicaApi.Application.IApplication;
using CrudPessoaFisicaApi.Data.IRepository;
using CrudPessoaFisicaApi.Domain.Entities;
using static CrudPessoaFisicaApi.Domain.Common.Constantes;

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
                throw new ApplicationException(ERRO_PESSOA_NAO_EXISTE);
            return pessoaFisica;
        }

        public List<PessoaFisica> GetAll()
        {
            var listapessoas = _pessoaFisicaRepository.GetAll();
            if (listapessoas == null)
                throw new ApplicationException(ERRO_NAO_EXISTEM_DADOS);
            return listapessoas;
        }

        public bool Post(PessoaFisica pessoaFisica)
        {
            return _pessoaFisicaRepository.Post(pessoaFisica);
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
