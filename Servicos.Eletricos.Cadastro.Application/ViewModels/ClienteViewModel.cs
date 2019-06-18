using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            Enderecos = new List<EnderecoViewModel>();
        }

        public Guid ClienteID { get;  set; }

        [Display(Name = "Nome", Description = " Primeiro nome e nome do meio")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        [Required(ErrorMessage = "Campo nome é obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Sobrenome", Description = "Último nome")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        [Required(ErrorMessage = "Campo sobrenome é obrigatório")]
        public string Sobrenome { get; set; }

        [Display(Name = "Nacionalidade")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string Nacionalidade { get; set; }
        public string RG { get; set; }

        [Display(Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Display (Name = "E-mail")]
        [RegularExpression(@"b[A-Z0-9._%-]+@[A-Z0-9.-]+.[A-Z]{2,4}b", ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [Display(Name = "CPF", Description = "")]
        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 números")]
        public string CPF { get; set; }

        [Display(Name = "Telefone Residencial")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Telefone residencial deve ter 11 números")]
        public string Telefone { get; set; }

        [Display(Name = "Telefone Celular")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "Telefone celular deve ter 12 números")]
        public string TelefoneCelular { get; set; }

        [Display(Name = "Ativo", Description = "Cliente está tivo?")]
        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }
        public List<EnderecoViewModel> Enderecos { get; set; }


        public void AdicionarEndereco(EnderecoViewModel enderecoViewModel)
        {
            Enderecos.Add(enderecoViewModel);
        }

        public void AdicionarEnderecos(List<EnderecoViewModel> enderecoViewModels)
        {
            Enderecos.AddRange(enderecoViewModels);
        }

    }
}
