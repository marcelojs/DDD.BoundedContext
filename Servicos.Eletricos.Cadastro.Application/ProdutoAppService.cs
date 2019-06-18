using Servicos.Eletricos.Cadastro.Application.Adapters;
using Servicos.Eletricos.Cadastro.Application.Interfaces;
using Servicos.Eletricos.Cadastro.Application.ViewModels;
using Servicos.Eletricos.Cadastro.Domain.Produtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoRepository produtoRepository, IProdutoService produtoService)
        {
            this._produtoRepository = produtoRepository;
            this._produtoService = produtoService;
        }

        public ProdutoViewModel Adicionar(ProdutoViewModel produtoViewModel)
        {
            var produtoDomain = _produtoService.Adicionar(ProdutoAdapter.ToDomain(produtoViewModel));
            produtoViewModel = null;
            return ProdutoAdapter.ToViewModel(produtoDomain);
        }

        public ProdutoViewModel Atualizar(ProdutoViewModel produtoViewModel)
        {
            var produtoDomain = _produtoService.Atualizar(ProdutoAdapter.ToDomain(produtoViewModel));
            produtoViewModel = null;
            return ProdutoAdapter.ToViewModel(produtoDomain);
        }

        public void Desativar(Guid produtoId)
        {
            _produtoService.DesativarProduto(produtoId);
        }

        public ProdutoViewModel ObterPorCodigo(string codigo)
        {
            var produtoDomain = _produtoRepository.ObterPorCodigo(codigo);
            return ProdutoAdapter.ToViewModel(produtoDomain);
        }

        public ProdutoViewModel ObterPorId(Guid id)
        {
            var produtoDomain = _produtoRepository.ObterPorId(id);
            return ProdutoAdapter.ToViewModel(produtoDomain);
        }

        public List<ProdutoListViewModel> ObterTodos()
        {
            return ProdutoAdapter.ToListViewModel(_produtoRepository.ObterTodos());
        }

    }
}
