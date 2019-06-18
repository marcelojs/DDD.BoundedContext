using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.PrestacaoServico.Domain.OrdemServico
{
    public class Orcamento
    {
        public Guid OrcamentoServicoId { get; private set; }
        public DateTime DataGerado { get; private set; }
        public decimal ValorTotal { get; private set; }
        public string Codigo { get; private set; }
    }
}
