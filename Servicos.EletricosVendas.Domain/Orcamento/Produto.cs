using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Vendas.Domain.Orcamento
{
    public class Produto
    {
        public Produto(Guid produtoId, string descricao, int quantidade, decimal valorUnitarioAcrescido, string tipoUnidade, Guid servidoId)
        {
            this.ProdutoId = produtoId;
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.ValorUnitarioAcrescido = valorUnitarioAcrescido;
            this.ValorTotal = 0;
            this.TipoUnidade = tipoUnidade;
            this.ServicoId = servidoId;
            CalcularQuantidadeEmCimaDoValorAcrescido(); 
        }

        public Guid ProdutoId { get; private set; }
        public Guid ServicoId { get; private set; }
        public string Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorTotal { get; private set; }
        public decimal ValorUnitarioAcrescido { get; private set; }
        public string TipoUnidade { get; private set; }

        public void CalcularQuantidadeEmCimaDoValorAcrescido()
        {
            this.ValorTotal = ValorUnitarioAcrescido * Quantidade;
        }

        public void VincularProdutoAoServico(Guid servicoId)
        {
            this.ServicoId = servicoId;
        }
        

    }
}
