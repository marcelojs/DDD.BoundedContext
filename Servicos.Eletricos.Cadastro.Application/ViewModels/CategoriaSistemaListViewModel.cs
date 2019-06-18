using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.ViewModels
{
    public class CategoriaSistemaListViewModel
    {
        public CategoriaSistemaListViewModel(Guid categoriaId, string descricao, bool ativo)
        {
            this.CategoriaId = categoriaId;
            this.Descricao = descricao;
            this.Ativo = ativo == true ? "Sim" : "Não";
        }

        public Guid CategoriaId { get; }
        public string Descricao { get; }
        public string Ativo { get; }
        public string DataCadastro { get;}

    }
}
