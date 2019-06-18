using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.ViewModels
{
    public class ServicoListViewModel
    {
        public ServicoListViewModel(Guid servicoId, string descricao, string valorVenda, bool ativo, string observacao, string codigo) {
            this.ServicoId = servicoId;
            this.Descricao = descricao;
            this.ValorVenda = valorVenda;
            this.Ativo = ativo == true ? "Sim" : "Não";
            this.Observacao = observacao;
            this.Codigo = codigo;
        }

        public Guid ServicoId { get; }
        public string Descricao { get; }
        public DateTime DataCadastro { get; }
        public string ValorVenda { get; }
        public string Ativo { get; }
        public string Observacao { get; }
        public string Codigo { get; }
    }
}
