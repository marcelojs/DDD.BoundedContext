using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Vendas.Domain.Orcamento
{
    public enum StatusOrcamento
    {
        Iniciado,
        Faturado,
        AguardandoRetornoCliente ,
        Cancelado,
        Congelado
    }
}
