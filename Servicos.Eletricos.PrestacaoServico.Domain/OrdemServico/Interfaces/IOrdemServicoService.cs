using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.PrestacaoServico.Domain.OrdemServico.Interfaces
{
    public interface IOrdemServicoService
    {

        OrdemServico ObterPorId(Guid id);
        void Atualizar(OrdemServico ordemServico);
        void Adicionar(OrdemServico ordemServico);
        List<OrdemServico> ObterOrdensServicoPorCondicao();

    }
}
