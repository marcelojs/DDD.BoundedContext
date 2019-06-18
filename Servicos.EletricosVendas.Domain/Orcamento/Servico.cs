using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Vendas.Domain.Orcamento
{
    public class Servico
    {
        public Guid ServicoId { get; private set; }
        public Guid OrcamentoId { get; private set; }
        //Enderco id ??  usar??
        public string Descricao { get; private set; }
        public decimal ValorTotalServicoComProdutos { get; private set; }
        public decimal ValorServico { get; private set; }
        public DateTime DataInsercao { get; private set; }
        public string Observacao { get; private set; }
        public ICollection<Produto> Produtos { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFimPrevista { get; private set; }
        public DateTime DataUltimAtualizacao { get; private set; }

        public Servico(Guid servicoId, string descricao, decimal valorServico, string observacao)
        {
            this.ServicoId = servicoId;
            this.Produtos = new List<Produto>();
            this.DataInsercao = DateTime.Now;
            this.Observacao = observacao;
            this.ValorServico = valorServico;
        }

        public void VincularParaOrcamento(Guid orcamentoServicoId)
        {
            this.OrcamentoId = orcamentoServicoId;
        }

        public void AdicionarProduto(Produto produto)
        {
            this.Produtos.Add(produto);
        }

        public void IniciarServico()
        {
            this.DataInicio = DateTime.Now;
        }

        public void FinalizarServico()
        {
            DataFimPrevista = DateTime.Now;
        }

        public void AtualizarDataUltimaAtualizacao()
        {
            this.DataUltimAtualizacao = DateTime.Now;
        }

        public decimal ObterValorTotalDoServicoComProdutos()
        {
            return CalcularValorTotalDoServicoComProdutos();
        }

        private decimal CalcularValorTotalDoServicoComProdutos()
        {
            ValorTotalServicoComProdutos = ValorServico;

            foreach (var produto in Produtos)
            {
                ValorTotalServicoComProdutos += produto.ValorTotal;
            }
            return ValorTotalServicoComProdutos;
        }

    }
}
