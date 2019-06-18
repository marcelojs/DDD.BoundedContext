using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Servicos.Eletricos.Core.Domain.ValueObjects
{
    public class Email
    {
        public const int TamanhoMaximo = 256;
        public const int TamanhoMinimo = 5;
        public string Endereco { get; set; }

        public Email(string endereco)
        {
            Endereco = endereco;
        }

        public static bool EhValido(string endereco)
        {
            //Aplicar expressão regular
            return true;
        }

    }
}
