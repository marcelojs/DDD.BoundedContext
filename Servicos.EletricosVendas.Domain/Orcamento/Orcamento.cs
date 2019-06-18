using Servicos.Eletricos.Core.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Vendas.Domain.Orcamento
{
    public class Orcamento : Entidade
    {
        public Guid OrcamentoServicoId { get; private set; }
        public Guid ClienteId { get; private set; }
        public DateTime DataGerado { get; private set; }
        public ICollection<Servico> Servicos { get; private set; }
        public StatusOrcamento StatusOrcamento { get; private set; }
        public decimal ValorTotal { get; private set; }
        public string Codigo { get; private set; }

        //Construtor para o EF
        protected Orcamento()
        { }

        public Orcamento(Guid clienteId)
        {
            this.OrcamentoServicoId = AnalisarId(clienteId);
            this.ClienteId = clienteId;
            this.DataGerado = DateTime.Now;
            this.Servicos = new List<Servico>();
            this.StatusOrcamento = StatusOrcamento.Iniciado;
            this.ValorTotal = 0;
        }

        public void VincularServicoParaOrcamento(Servico servico)
        {
            servico.VincularParaOrcamento(OrcamentoServicoId);
            this.Servicos.Add(servico);
        }

        public void AlterarStatusOrcamento(StatusOrcamento status)
        {
            //Verificar seu funcionamento
            this.StatusOrcamento = status;
        }

        private decimal CalcularValorTotalOrcamento()
        {
            foreach (var servico in Servicos)
            {
                ValorTotal += servico.ObterValorTotalDoServicoComProdutos();
            }
            return ValorTotal;
        }

        public decimal ObterValorTotal()
        {
            return CalcularValorTotalOrcamento();
        }
    }
}
