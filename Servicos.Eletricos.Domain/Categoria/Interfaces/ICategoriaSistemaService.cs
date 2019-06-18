using System;
using System.Collections.Generic;
using System.Text;
using Servicos.Eletricos.Cadastro.Domain.Categoria;

namespace Servicos.Eletricos.Cadastro.Domain.Categoria.Interfaces
{
    public interface ICategoriaSistemaService
    {
        CategoriaSistema Adicionar(CategoriaSistema categoriasSistemas);
        CategoriaSistema Atualizar(CategoriaSistema categoriasSistemas);
        CategoriaSistema ObterPorId(Guid id);
        CategoriaSistema ObterPorDescricao(string descricao);
        List<CategoriaSistema> ObterTodos();
        //Analisar depois
        List<CategoriaSistema> ObterTodosPorCondicao(/*analisar trecho para condição*/);
        void Inativar(Guid categoriaSistemaId);
    }
}
