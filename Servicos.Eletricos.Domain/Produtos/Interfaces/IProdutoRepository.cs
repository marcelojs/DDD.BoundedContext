using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Domain.Produtos.Interfaces
{
    public interface IProdutoRepository
    {
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        Produto ObterPorId(Guid id);
        Produto ObterPorCodigo(string codigo);
        List<Produto> ObterTodos();//Verificar trecho expression
    }
}
