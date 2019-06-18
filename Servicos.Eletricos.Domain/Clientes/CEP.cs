using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Servicos.Eletricos.Cadastro.Domain.Clientes
{
    public class CEP
    {
        public string NumeroCep { get; private set; }
        public const int TamanhoMaximo = 8;

        public CEP(string cep) {
            this.NumeroCep = cep;
        }

        public string ObterCepFormatado() {

            //Verificar se cada caracter da string é um número

            if (NumeroCep.Length < 8)
                return NumeroCep.PadLeft(8 - NumeroCep.Length, '0');

            if (NumeroCep == "" || NumeroCep == null)
                return "";

            return NumeroCep.Substring(0, 5) + "-" + NumeroCep.Substring(5, 3);
        }

    }
}
