using Servicos.Eletricos.Cadastro.Application.ViewModels;
using Servicos.Eletricos.Cadastro.Domain.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.Interfaces
{
    public interface IProdutoAppService
    {
        ProdutoViewModel Adicionar(ProdutoViewModel produtoViewModel);
        ProdutoViewModel Atualizar(ProdutoViewModel produtoViewModel);
        ProdutoViewModel ObterPorId(Guid id);
        ProdutoViewModel ObterPorCodigo(string codigo);
        void Desativar(Guid produtoId);
        List<ProdutoListViewModel> ObterTodos();

    }
}
