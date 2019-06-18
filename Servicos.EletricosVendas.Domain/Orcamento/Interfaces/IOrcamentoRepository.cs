using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Vendas.Domain.Orcamento.Interfaces
{
    public interface IOrcamentoRepository
    {
        void Adicionar(Orcamento orcamento);
        void Atualizar(Orcamento orcamento);
        Orcamento ObterPorId(Guid id);
        List<Orcamento> ObterTodos();
    }
}
