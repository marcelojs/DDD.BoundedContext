using Servicos.Eletricos.Cadastro.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.Interfaces
{
    public interface ICategoriaSistemaAppService
    {
        CategoriaSistemaViewModel ObterPorId(Guid categoriaId);
        CategoriaSistemaViewModel Adicionar(CategoriaSistemaViewModel categoriaSistemaViewModel);
        CategoriaSistemaViewModel Atualizar(CategoriaSistemaViewModel categoriaSistemaViewModel);
        void Inativar(Guid categoriaId);
        CategoriaSistemaViewModel ObterPorDescricao(string descricao);
        List<CategoriaSistemaListViewModel> ObterTodos();
    }
}
