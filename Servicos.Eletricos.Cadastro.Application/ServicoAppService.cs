using Servicos.Eletricos.Cadastro.Application.Adapters;
using Servicos.Eletricos.Cadastro.Application.Interfaces;
using Servicos.Eletricos.Cadastro.Application.ViewModels;
using Servicos.Eletricos.Cadastro.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application
{
    public class ServicoAppService : IServicoAppService
    {
        private readonly IServicoService _servicoService;
        private readonly IServicoRepository _servicoRepository;

        public ServicoAppService(IServicoService servicoService, IServicoRepository servicoRepository)
        {
            this._servicoService = servicoService;
            this._servicoRepository = servicoRepository;
        }

        public ServicoViewModel Adicionar(ServicoViewModel servicoViewModel)
        {
            var servicoDomain = _servicoService.Adicionar(ServicoAdapter.ToDomain(servicoViewModel));
            servicoViewModel = null;
            return ServicoAdapter.ToViewModel(servicoDomain);
        }

        public ServicoViewModel Atualizar(ServicoViewModel servicoViewModel)
        {
            var servicoDomain = _servicoService.Atualizar(ServicoAdapter.ToDomain(servicoViewModel));
            servicoViewModel = null;
            return ServicoAdapter.ToViewModel(servicoDomain);
        }

        public void InativarServico(Guid servicoId)
        {
            _servicoService.InativarServico(servicoId);
        }

        public ServicoViewModel ObterPorCodigo(string codigo)
        {
            var servico = _servicoRepository.ObterPorCodigo(codigo);
            return ServicoAdapter.ToViewModel(servico);
        }

        public ServicoViewModel ObterPorId(Guid servicoId)
        {
            var servico = _servicoRepository.ObterPorId(servicoId);
            return ServicoAdapter.ToViewModel(servico);
        }

        public List<ServicoListViewModel> ObterTodos()
        {
            var servicos = _servicoRepository.ObterTodos();
            return ServicoAdapter.ToListViewModel(servicos);
        }
    }
}
