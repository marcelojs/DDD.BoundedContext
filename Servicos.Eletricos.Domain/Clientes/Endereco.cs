using Servicos.Eletricos.Core.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;


namespace Servicos.Eletricos.Cadastro.Domain.Clientes
{
    public class Endereco : Entidade
    {
        public Endereco(Guid enderecoId, int numero, string bairro, string cidade,
            string estado, string logradouro, string complemento, string cep,
            DateTime? dataCadastro, Guid? clienteId)
        {
            this.EnderecoId = enderecoId;//AnalisarId(enderecoId);
            this.Numero = numero;//Realizar validação com fluentvalidation
            this.Bairro = bairro;//Realizar validação com fluentvalidation
            this.Cidade = cidade;//Realizar validação com fluentvalidation
            this.Estado = estado; // Será analisado possível mudança para entidade
            this.Logradouro = logradouro;//Realizar validação com fluentvalidation
            this.Complemento = complemento;//Realizar validação com fluentvalidation
            this.DataCadastro = enderecoId != Guid.Empty ? dataCadastro.Value : DateTime.Now;
            this.ClienteId = clienteId.Value != null ? clienteId.Value : Guid.Empty;
            DefinirCep(cep);
        }

        public Guid EnderecoId { get; private set; }
        public Guid ClienteId { get; private set; }
        public int Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public CEP CEP { get; private set; }

        //Para o EF
        protected Endereco()
        {

        }

        public void DefinirCep(string numeroCep)
        {
            //Realizar validação por fluent validation antes                
            this.CEP = new CEP(numeroCep);
        }

        public void VincularEnderecoAoCliente(Guid clienteId)
        {
            this.ClienteId = clienteId;
        }

        public void AdicionarIdentidade()
        {
            this.EnderecoId = AnalisarId(this.EnderecoId);
        }
    }

}
