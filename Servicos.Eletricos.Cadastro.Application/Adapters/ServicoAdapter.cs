using Servicos.Eletricos.Cadastro.Application.ViewModels;
using Servicos.Eletricos.Cadastro.Domain.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.Adapters
{
    public class ServicoAdapter
    {
        public static Servico ToDomain(ServicoViewModel servicoViewModel)
        {
            var servicoDomain = new Servico(
                servicoViewModel.ServicoId,
                servicoViewModel.Descricao,
                servicoViewModel.DataCadastro,
                servicoViewModel.ValorVenda,
                servicoViewModel.Observacao, 
                servicoViewModel.Codigo);

            return servicoDomain;
        }

        public static ServicoViewModel ToViewModel(Servico servico)
        {
            var servicoViewModel = new ServicoViewModel()
            {
                ServicoId = servico.ServicoId,
                Codigo = servico.Codigo,
                Ativo = servico.Ativo,
                DataCadastro = servico.DataCadastro,
                Descricao = servico.Descricao,
                Observacao = servico.Observacao,
                ValorVenda = servico.ValorVenda
            };

            return servicoViewModel;
        }

        public static List<ServicoListViewModel> ToListViewModel(List<Servico> servicos)
        {
            List<ServicoListViewModel> servicosListViewModel = new List<ServicoListViewModel>();

            foreach (var servico in servicos)
            {
                servicosListViewModel.Add(new ServicoListViewModel(
                    servico.ServicoId,
                    servico.Descricao,
                    servico.ValorVenda.ToString(),
                    servico.Ativo,
                    servico.Observacao, 
                    servico.Codigo));
            }

            return servicosListViewModel;
        }
    }
}
