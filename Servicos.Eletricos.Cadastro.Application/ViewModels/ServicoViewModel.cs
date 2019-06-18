using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Servicos.Eletricos.Cadastro.Application.ViewModels
{
    public class ServicoViewModel
    {
        public Guid ServicoId { get;  set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
      
        [Display (Name = "Valor Venda")]
        public decimal ValorVenda { get;  set; }

        [Display(Name = "Ativo")]
        public bool Ativo { get;  set; }

        [Display(Name = "Observação")]
        public string Observacao { get; set; }

        [Display(Name = "Código")]
        public string Codigo { get;  set; }

        [Display(Name = "Data Cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}
