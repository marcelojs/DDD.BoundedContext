using Servicos.Eletricos.Core.Domain.Validation;
using Servicos.Eletricos.Core.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Domain.Clientes
{
    public class Cliente : Entidade
    {
        public Cliente(
            Guid clienteId, string nome, string sobrenome, 
            string cpf, DateTime? dataCadastro, DateTime dataNascimento = new DateTime(), string email = "", string nacionalidade = "", 
            bool ativar = false, string rg = "", string telefone = "", string telefoneCelular = "")
        {
            this.ClienteID = clienteId;
            this.DataCadastro = clienteId != Guid.Empty ? dataCadastro.Value : DateTime.Now;
            this.Nome = nome; // Validacao será feita por fluentvalidation
            this.Sobrenome = sobrenome;

            this.Nacionalidade = nacionalidade; // Validacao será feita por fluentvalidation
            this.RG = rg;
            this.DataNascimento = dataNascimento;
            this.Ativo = ativar;
            this.Telefone = telefone;
            this.TelefoneCelular = telefoneCelular;

            this.Enderecos = new List<Endereco>();
            DefinirCPF(cpf);
            DefinirEmail(email);
        }

        //Para EF
        protected Cliente()
        { }

        public Guid ClienteID { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public bool Ativo { get; private set; }
        public string Nacionalidade { get; private set; }
        public string RG { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Email Email { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public CPF CPF { get; private set; }
        public List<Endereco> Enderecos { get; private set; }
        public string Telefone { get; private set; }
        public string TelefoneCelular { get; private set; }

        public void DefinirCPF(string cpf)
        {
            var meuCPF = new CPF(cpf);
            //Validações de CPF
            //...
            
        }

        public void DefinirEmail(string email)
        {
            if (email != "")
            {
                var meuEmail = new Email(email);
                //Validações de Email
                //...

            }
            
        }

        public bool VerificarSeClienteEhAniversariante()
        {
            if (DataNascimento.ToString("dd/MM") == DateTime.Now.ToString("dd/MM"))
                return true;
            else
                return false;
        }

        public void AdicionarEndereco(Endereco endereco) {
            Enderecos.Add(endereco);
        }

        public void Inativar()
        {
            this.Ativo = false;
        }

        public void Ativar()
        {
            this.Ativo = true;
        }

        public void AdicionarIdentidade() {

            this.ClienteID = AnalisarId(this.ClienteID);

        }

    }
}
