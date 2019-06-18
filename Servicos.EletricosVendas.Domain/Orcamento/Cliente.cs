using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Vendas.Domain.Orcamento
{
    public class Cliente
    {
        public Cliente(Guid clienteId, string nome, string cpf, string telefone, string telefoneCelular, List<Endereco> enderecos) {

            this.ClienteID = clienteId;
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.TelefoneCelular = telefoneCelular;
            this.Enderecos = enderecos;
        }

        public Guid ClienteID { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public List<Endereco> Enderecos { get; private set; }
        public string Telefone { get; private set; }
        public string TelefoneCelular { get; private set; }
    }
}
