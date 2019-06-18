using Servicos.Eletricos.Vendas.Domain.Orcamento.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Vendas.Domain.Orcamento.Services
{
    public class OrcamentoService : IOrcamentoService
    {
        private readonly IOrcamentoRepository _orcamentoRepository;

        public OrcamentoService(IOrcamentoRepository orcamentoRepository)
        {
            _orcamentoRepository = orcamentoRepository;
        }

        public void Adicionar(Orcamento orcamento)
        {
            _orcamentoRepository.Adicionar(orcamento);
        }

        public void Atualizar(Orcamento orcamento)
        {
            _orcamentoRepository.Atualizar(orcamento);
        }

        public Orcamento ObterPorId(Guid id)
        {
            return _orcamentoRepository.ObterPorId(id);
        }

        public List<Orcamento> ObterTodos()
        {
            return _orcamentoRepository.ObterTodos();
        }
    }
}
