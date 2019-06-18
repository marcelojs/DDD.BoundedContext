using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.PrestacaoServico.Domain.OrdemServico
{
    public class Produtos
    {
        public Produtos(Guid produtoId, Guid servicoId, string descricao, int quantidade, decimal valorTotal, string tipoUnidade) {

            this.ProdutoId = produtoId;
            this.ServicoId = servicoId;
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.ValorTotal = valorTotal;
            this.TipoUnidade = tipoUnidade;
        }

        public Guid ProdutoId { get; private set; }
        public Guid ServicoId { get; private set; }
        public string Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorTotal { get; private set; }
        public string TipoUnidade { get; private set; }
    }
}
