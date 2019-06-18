using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Vendas.Domain.Orcamento
{
    public class Endereco
    {
        public Endereco(Guid enderecoId, Guid clienteId, string numero, string bairro, string cidade, string estado, string logradouro, string complemento, string cep)
        {
            this.EnderecoId = enderecoId;
            this.ClienteId = clienteId;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Logradouro = logradouro;
            this.Complemento = complemento;
            this.CEP = cep;
        }

        public Guid EnderecoId { get; }
        public Guid ClienteId { get; }
        public string Numero { get; }
        public string Bairro { get; }
        public string Cidade { get; }
        public string Estado { get; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }

        public string ObterEnderecoCompleto()
        {
            return Cidade + " " + Estado + " " + CEP + " " + Bairro + " " + Logradouro + " " + Complemento + " " + Numero;
        }


    }
}
