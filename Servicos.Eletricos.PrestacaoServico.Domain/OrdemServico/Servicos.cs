using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.PrestacaoServico.Domain.OrdemServico
{
    public class Servicos
    {
        public Servicos(Guid servicoId, string descricao, decimal valorTotal, DateTime dataInsercao, string observacao, List<Produtos> produtos) {

            this.ServicoId = servicoId;
            this.Descricao = descricao;
            this.ValorTotal = valorTotal;
            this.DataInsercao = dataInsercao;
            this.Observacao = observacao;
            this.Produtos = produtos;
        }

        public Guid ServicoId { get; private set; }
        public string Descricao { get; private set; }
        //public decimal ValorTotalServicoComProdutos { get; private set; }
        //public decimal ValorServico { get; private set; }
        public decimal ValorTotal { get; private set; }
        public DateTime DataInsercao { get; private set; }
        public string Observacao { get; private set; }
        public ICollection<Produtos> Produtos { get; private set; }
        //public DateTime DataInicio { get; private set; }
        //public DateTime DataFimPrevista { get; private set; }
    }
}
