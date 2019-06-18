
using Servicos.Eletricos.Core.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.PrestacaoServico.Domain.OrdemServico
{
    public class OrdemServico : Entidade
    {
        protected OrdemServico() { }

        public OrdemServico(Guid idOS, Orcamento orcamento, StatusOrdemServico statusOrdemServico)
        {
            this.OrdemServicoId = AnalisarId(idOS);
            this.Orcamento = orcamento;
            this.Servicos = new List<Servicos>();
            this.StatusOrdemServico = statusOrdemServico;
        }

        public Guid OrdemServicoId { get; private set; }
        public Orcamento Orcamento { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFinalizado { get; private set; }
        public ICollection<Servicos> Servicos { get; private set; }
        public StatusOrdemServico StatusOrdemServico { get; private set; }

        public void IniciarOrdemServico() {
            DataInicio = DateTime.Now;
        }

        public void FinalizarOrdemService() {
            DataFinalizado = DateTime.Now;
        }




    }
}
