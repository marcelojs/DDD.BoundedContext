using Servicos.Eletricos.PrestacaoServico.Domain.OrdemServico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.PrestacaoServico.Domain.OrdemServico.Services
{
    public class OrdemServicoService : IOrdemServicoService
    {
        private readonly IOrdemServicoRepository _ordemServicoRepository;
      
        public OrdemServicoService(IOrdemServicoRepository ordemServicoRepository)
        {
            _ordemServicoRepository = ordemServicoRepository;
        }

        public void Adicionar(OrdemServico ordemServico)
        {
            _ordemServicoRepository.Adicionar(ordemServico);
        }

        public void Atualizar(OrdemServico ordemServico)
        {
            _ordemServicoRepository.Atualizar(ordemServico);
        }

        public List<OrdemServico> ObterOrdensServicoPorCondicao()
        {
            throw new NotImplementedException();
        }

        public OrdemServico ObterPorId(Guid id)
        {
            return _ordemServicoRepository.ObterPorId(id);
        }
    }
}
