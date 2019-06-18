using Servicos.Eletricos.Cadastro.Domain.Categoria;
using Servicos.Eletricos.Cadastro.Domain.Produtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Domain.Produtos.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }


        public Produto Adicionar(Produto produto)
        {
            if (produto.EhValido())
            {
                produto.AdicionarIdentidade();
                _produtoRepository.Adicionar(produto);
            }
            else
                return produto;

            return produto;
        }

        public Produto Atualizar(Produto produto)
        {
            if (produto.EhValido())
                _produtoRepository.Atualizar(produto);
            else
                return produto;

            return produto;
        }

        public void DesativarProduto(Guid produtoId)
        {
            var produto =_produtoRepository.ObterPorId(produtoId);
            produto.Desativar();
            _produtoRepository.Atualizar(produto);
        }

        public Produto ObterPorCodigo(string codigo)
        {
            return _produtoRepository.ObterPorCodigo(codigo);
        }

        public Produto ObterPorId(Guid id)
        {
            return _produtoRepository.ObterPorId(id);
        }

        public List<Produto> ObterTodos()
        {
            return _produtoRepository.ObterTodos();
        }
       
    }
}
