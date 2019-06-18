using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Core.Domain.ValueObjects
{
    public class Porcentagem
    {
        public Porcentagem(decimal valor)
        {
            //Metodo para análise do valor     
        }

        public decimal Valor { get; private set; }
    }
}
