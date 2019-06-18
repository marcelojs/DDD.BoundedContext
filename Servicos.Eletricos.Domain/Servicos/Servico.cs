using System;
using System.Collections.Generic;
using System.Text;
using Servicos.Eletricos.Cadastro.Domain.Produtos;
using Servicos.Eletricos.Core.Domain.Validation;
using Servicos.Eletricos.Core.Domain.ValueObjects;

namespace Servicos.Eletricos.Cadastro.Domain.Servicos
{
    public class Servico : Entidade
    {
        public Servico(Guid servicoId, string descricao, DateTime dataCadastro, decimal valorVenda, string observacao, string codigo)
        {
            this.ServicoId = servicoId;      
            this.Descricao = descricao; // validação por fluentvalidation
            this.Observacao = observacao; // validação por fluentvalidation
            this.Codigo = codigo; // validação por fluentvalidation
            this.DataCadastro = servicoId == null ? DateTime.Now : dataCadastro;
            this.ValorVenda = valorVenda; // validação por fluentvalidation
        }

        public Guid ServicoId { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public decimal ValorVenda { get; private set; }
        public bool Ativo { get; private set; }
        public string Observacao { get; private set; }
        public string Codigo { get; private set; }

        public void Ativar() {
            Ativo = true;
        }

        public void Inativar() {
            Ativo = false;
        }

        public void AdicionarIdentidade() {
            this.ServicoId = AnalisarId(this.ServicoId);
        }



    }
}
