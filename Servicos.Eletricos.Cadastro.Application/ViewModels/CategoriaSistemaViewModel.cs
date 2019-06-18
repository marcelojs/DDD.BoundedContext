using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Servicos.Eletricos.Cadastro.Application.ViewModels
{
    public class CategoriaSistemaViewModel
    {
        public Guid CategoriaId { get;  set; }

        [Display(Name = "Descrição")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        [Required(ErrorMessage = "Campo descrição é obrigatório")]
        public string Descricao { get; set; }

        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }

        [Display(Name = "Data Cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}
