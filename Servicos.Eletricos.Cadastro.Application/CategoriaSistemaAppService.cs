using Servicos.Eletricos.Cadastro.Application.Adapters;
using Servicos.Eletricos.Cadastro.Application.Interfaces;
using Servicos.Eletricos.Cadastro.Application.ViewModels;
using Servicos.Eletricos.Cadastro.Domain.Categoria.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application
{
    public class CategoriaSistemaAppService : ICategoriaSistemaAppService
    {
        private readonly ICategoriaSistemaRepository _categoriaSistemaRepository;
        private readonly ICategoriaSistemaService _categoriaSistemaService;

        public CategoriaSistemaAppService(
            ICategoriaSistemaRepository categoriaSistemaRepository,
            ICategoriaSistemaService categoriaSistemaService)
        {
            this._categoriaSistemaRepository = categoriaSistemaRepository;
            this._categoriaSistemaService = categoriaSistemaService;
        }

        public CategoriaSistemaViewModel Adicionar(CategoriaSistemaViewModel categoriaSistemaViewModel)
        {
            var categoriaDomain = _categoriaSistemaRepository.Adicionar(CategoriaSistemaAdapter.ToDomain(categoriaSistemaViewModel));
            categoriaSistemaViewModel = null;
            return CategoriaSistemaAdapter.ToViewModel(categoriaDomain);
        }

        public CategoriaSistemaViewModel Atualizar(CategoriaSistemaViewModel categoriaSistemaViewModel)
        {
            var categoriaDomain = _categoriaSistemaService.Atualizar(CategoriaSistemaAdapter.ToDomain(categoriaSistemaViewModel));
            categoriaSistemaViewModel = null;
            return CategoriaSistemaAdapter.ToViewModel(categoriaDomain);
        }

        public void Inativar(Guid categoriaId)
        {
            _categoriaSistemaService.Inativar(categoriaId);
        }

        public CategoriaSistemaViewModel ObterPorDescricao(string descricao)
        {
            return CategoriaSistemaAdapter.ToViewModel(_categoriaSistemaRepository.ObterPorDescricao(descricao));
        }

        public CategoriaSistemaViewModel ObterPorId(Guid categoriaId)
        {
            return CategoriaSistemaAdapter.ToViewModel(_categoriaSistemaRepository.ObterPorId(categoriaId));
        }

        public List<CategoriaSistemaListViewModel> ObterTodos()
        {
            return CategoriaSistemaAdapter.ToViewModelList(_categoriaSistemaRepository.ObterTodos());
        }
    }
}
