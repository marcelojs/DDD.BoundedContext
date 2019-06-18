using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Domain.Servicos.Interfaces
{
    public interface IServicoService
    {

        Servico Adicionar(Servico servico);
        Servico Atualizar(Servico servico);
        Servico ObterPorId(Guid id);
        Servico ObterPorDescricao(string descricao);
        Servico ObterPorCodigo(string codigo);
        void InativarServico(Guid servicoId);
    }
}
