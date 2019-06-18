using Servicos.Eletricos.Core.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Domain.Categoria
{
    public class CategoriaSistema : Entidade
    {
        //Verificar se existe tamanho máximo e mínimo para cadastrar categoria
        public CategoriaSistema(Guid categoriaId, string descricao, DateTime dataCadastro, bool ativo = false)
        {
            this.CategoriaId = categoriaId;//AnalisarId(categoriaId);
            this.DataCadastro = categoriaId != null ? dataCadastro : DateTime.Now;
            this.Descricao = this.VerificarSeCategoriaSistemaEhValido(descricao);
            this.Ativo = ativo;
        }

        public Guid CategoriaId { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public void AdicionarIdentidade()
        {
            this.CategoriaId = AnalisarId(this.CategoriaId);
        }

        public void Inativar() {
            Ativo = false;
        }

        public void Ativar() {
            Ativo = true;
        }

    }
}
