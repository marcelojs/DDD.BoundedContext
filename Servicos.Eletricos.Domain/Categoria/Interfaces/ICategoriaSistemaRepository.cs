using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Domain.Categoria.Interfaces
{
    public interface ICategoriaSistemaRepository
    {
        CategoriaSistema Adicionar(CategoriaSistema categoriasSistemas);
        CategoriaSistema Atualizar(CategoriaSistema categoriasSistemas);
        CategoriaSistema ObterPorId(Guid id);
        CategoriaSistema ObterPorDescricao(string descricao);
        List<CategoriaSistema> ObterTodos();
        List<CategoriaSistema> ObterTodosPorCondicao(/*analisar trecho para condição*/);
        void Inativar(Guid categoriaId);
    }
}
