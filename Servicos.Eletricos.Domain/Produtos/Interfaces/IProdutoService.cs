using Servicos.Eletricos.Cadastro.Domain.Categoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Domain.Produtos.Interfaces
{
    public interface IProdutoService
    {
        Produto Adicionar(Produto produto);
        Produto Atualizar(Produto produto);
        Produto ObterPorId(Guid id);
        Produto ObterPorCodigo(string codigo);
        List<Produto> ObterTodos();//Verificar trecho expression
        void DesativarProduto(Guid produtoId);
    }
}
