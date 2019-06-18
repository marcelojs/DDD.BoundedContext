using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.ViewModels
{
    public class ProdutoListViewModel
    {
        public ProdutoListViewModel(Guid produtoId, string descricao, string tipoUnidade, string quantidade,
            string marca, string modelo, string valorCompra, string porcentagem, string valorVenda, bool ativo, string codigo, string categoriaSistema)
        {
            this.Descricacao = descricao;
            this.TipoUnidade = tipoUnidade;
            this.Quantidade = quantidade;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Porcentagem = porcentagem;
            this.ValorCompra = valorCompra;
            this.ValorVenda = ValorVenda;
            this.Ativo = ativo == true ? "Sim" : "Não";
            this.Codigo = codigo;
            this.CategoriaSistema = categoriaSistema;
        }


        public Guid ProdutoId { get; }
        public string Descricacao { get; }
        public string TipoUnidade { get; }
        public string Quantidade { get; }
        public string Marca { get; }
        public string Modelo { get; }
        public string ValorCompra { get; }
        public string Porcentagem { get; }
        public string ValorVenda { get; }
        public string Ativo { get; }
        public string Codigo { get; }
        public string CategoriaSistema { get; set; }
    }
}
