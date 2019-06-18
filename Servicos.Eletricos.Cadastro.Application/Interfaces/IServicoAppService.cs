using Servicos.Eletricos.Cadastro.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.Interfaces
{
    public interface IServicoAppService
    {
        ServicoViewModel ObterPorId(Guid servicoId);
        ServicoViewModel ObterPorCodigo(string codigo);
        List<ServicoListViewModel> ObterTodos();
        ServicoViewModel Adicionar(ServicoViewModel servicoViewModel);
        ServicoViewModel Atualizar(ServicoViewModel servicoViewModel);
        void InativarServico(Guid servicoId);
    }
}
