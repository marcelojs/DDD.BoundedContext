using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Domain.Servicos.Interfaces
{
    public interface IServicoRepository
    {
        void Adicionar(Servico servico);
        void Atualizar(Servico servico);
        Servico ObterPorId(Guid id);
        Servico ObterPorDescricao(string descricao);
        Servico ObterPorCodigo(string codigo);
        List<Servico> ObterTodos();
    }
}
