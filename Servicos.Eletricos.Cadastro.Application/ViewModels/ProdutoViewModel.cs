using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Servicos.Eletricos.Cadastro.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public Guid ProdutoId { get; set; }

        [Display(Name = "Descrição")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        [Required(ErrorMessage = "Campo descrição é obrigatório")]
        public string Descricacao { get; set; }

        [Display(Name = "Data Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Tipo Unidade")]
        public string TipoUnidade { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Valor Compra")]
        public decimal ValorCompra { get;  set; } 

        [Display(Name = "Porcentagem")]
        public decimal Porcentagem { get; set; }

        [Display(Name = "Valor Venda")]
        public decimal ValorVenda { get; set; }

        [Display(Name = "Ativo")]
        public bool Ativo { get;  set; }

        [Display(Name = "Codigo")]
        public string Codigo { get; set; }

        public CategoriaSistemaViewModel CategoriaSistemasViewModel { get;  set; }
    }
}
