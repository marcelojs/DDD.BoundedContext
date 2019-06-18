using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.ViewModels
{
    public class ClienteListViewModel
    {
        public ClienteListViewModel(Guid clienteId, string nome, string sobrenome, bool ativo,
            string nacionalidade, string CPF, string telefone, string telefoneCelular)
        {
            this.ClienteID = clienteId;
            this.nome = nome.Trim();
            this.sobrenome = sobrenome.Trim();
            this.Ativo = ativo == true ? "Sim" : "Não";
            this.Nacionalidade = nacionalidade.Trim();
            this.CPF = CPF.Trim();
            this.Telefone = telefone.Trim();
            this.TelefoneCelular = telefoneCelular.Trim();
        }

        public Guid ClienteID { get; }
        public string NomeCompleto { get { return nome + " " + sobrenome; } }
        public string Ativo { get; }
        public string Nacionalidade { get; }
        public string CPF { get; }
        public string Telefone { get; }
        public string TelefoneCelular { get; }

        private string nome;
        private string sobrenome;
    }
}
