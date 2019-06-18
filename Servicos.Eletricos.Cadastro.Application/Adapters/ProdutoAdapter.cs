using Servicos.Eletricos.Cadastro.Application.ViewModels;
using Servicos.Eletricos.Cadastro.Domain.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.Adapters
{
    public class ProdutoAdapter
    {
        public static Produto ToDomain(ProdutoViewModel produtoViewModel) {

            var produto = new Produto(
               produtoViewModel.ProdutoId,
               produtoViewModel.Descricacao,
               produtoViewModel.DataCadastro,
               produtoViewModel.TipoUnidade, 
               produtoViewModel.Quantidade,
               produtoViewModel.Marca,
               produtoViewModel.ValorCompra,
               produtoViewModel.Codigo, 
               CategoriaSistemaAdapter.ToDomain(produtoViewModel.CategoriaSistemasViewModel),
               produtoViewModel.Modelo, 
               produtoViewModel.Porcentagem, 
               produtoViewModel.Ativo);

            return produto;
        }

        public static ProdutoViewModel ToViewModel(Produto produto) {

            var produtoViewModel = new ProdutoViewModel()
            {
                ProdutoId = produto.ProdutoId,
                Descricacao = produto.Descricacao,
                Marca = produto.Marca,
                Modelo = produto.Modelo,
                DataCadastro = produto.DataCadastro,
                Porcentagem = produto.Porcentagem,
                Ativo = produto.Ativo,
                CategoriaSistemasViewModel = CategoriaSistemaAdapter.ToViewModel(produto.CategoriaSistemas),
                Codigo = produto.Codigo,
                Quantidade = produto.Quantidade,
                TipoUnidade = produto.TipoUnidade,
                ValorCompra = produto.ValorCompra,
                ValorVenda = produto.ValorVenda
            };

            return produtoViewModel;
        }

        public static List<ProdutoListViewModel> ToListViewModel(List<Produto> produtos) {

            List<ProdutoListViewModel> produtoListViewModels = new List<ProdutoListViewModel>();

            foreach (var produto in produtos) {

                produtoListViewModels.Add(new ProdutoListViewModel(
                    produto.ProdutoId, 
                    produto.Descricacao, 
                    produto.TipoUnidade,
                    produto.Quantidade.ToString(), 
                    produto.Marca, 
                    produto.Modelo,
                    produto.ValorCompra.ToString(), 
                    produto.Porcentagem.ToString(), 
                    produto.ValorVenda.ToString(), 
                    produto.Ativo, 
                    produto.Codigo, 
                    produto.CategoriaSistemas.Descricao));
            }

            return produtoListViewModels;
        }

    }
}
