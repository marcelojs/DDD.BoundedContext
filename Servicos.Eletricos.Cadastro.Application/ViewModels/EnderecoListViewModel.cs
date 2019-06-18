using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.ViewModels
{
    public class EnderecoListViewModel
    {

        public EnderecoListViewModel(Guid enderecoId, string numero, string bairro, string cidade, 
            string estado, string logradouro, string complemento, string cep )
        {
            this.EnderecoId = enderecoId;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Logradouro = logradouro;
            this.Complemento = complemento;
            this.CEP = cep;
        }

        public Guid EnderecoId { get; }
        public string Numero { get; }
        public string Bairro { get; }
        public string Cidade { get; }
        public string Estado { get; }
        public string Logradouro { get; }
        public string Complemento { get; }
        public string CEP { get; }
    }
}
