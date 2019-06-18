using System;
using System.Collections.Generic;
using System.Text;
using Servicos.Eletricos.Cadastro.Domain.Categoria;
using Servicos.Eletricos.Core.Domain.Validation;
using Servicos.Eletricos.Core.Domain.ValueObjects;

namespace Servicos.Eletricos.Cadastro.Domain.Produtos
{
    public class Produto : Entidade
    {
        //For EF
        protected Produto()
        { }

        public Produto(
            Guid produtoId, string descricao, DateTime dataCadastro,
            string tipoUnidade, int quantidade,
            string marca, decimal valorCompra,string codigo,
            CategoriaSistema categoriasSistemas, string modelo = "", decimal porcentagem = 0, bool ativo = false)
        {
            this.ProdutoId = produtoId;
            this.Descricacao = descricao; // Será feito validação por fluent validation
            this.TipoUnidade = tipoUnidade;  // Será feito validação por fluent validation
            this.Marca = marca;  // Será feito validação por fluent validation
            this.Codigo = codigo;  // Será feito validação por fluent validation
            this.DataCadastro = produtoId != null ? dataCadastro : DateTime.Now;

            this.ValorCompra = valorCompra;  // Será feito validação por fluent validation
            this.Porcentagem = porcentagem;  // Será feito validação por fluent validation
            this.Quantidade = quantidade;  // Será feito validação por fluent validation
            this.ValorVenda = 0;
            this.Ativo = ativo;
            
            this.CategoriaSistemas = categoriasSistemas;

            this.Modelo = modelo;
            CalcularValorVenda();
        }

        public Guid ProdutoId { get; private set; }
        public string Descricacao { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string TipoUnidade { get; private set; }
        public int Quantidade { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public decimal ValorCompra { get; private set; } // 350
        public decimal Porcentagem { get; private set; }//-- 20%
        public decimal ValorVenda { get; private set; } // 350 * 0,20 = 420
        public bool Ativo { get; private set; }
        public string Codigo { get; private set; }
        public CategoriaSistema CategoriaSistemas { get; private set; }

        public void Ativar()
        {
            Ativo = true;
        }

        public void Desativar()
        {
            Ativo = false;
        }

        private void CalcularValorVenda()
        {
            var valorPorcentagem = Porcentagem * ValorCompra;

            if (valorPorcentagem == 0)
                ValorVenda = ValorCompra;
            else
                ValorVenda = ValorCompra + valorPorcentagem;
        }

        public decimal RetornarValorVenda()
        {
            return ValorVenda;
        }

        public void AdicionarIdentidade()
        {
            this.ProdutoId = AnalisarId(this.ProdutoId);
        }
    }
}
