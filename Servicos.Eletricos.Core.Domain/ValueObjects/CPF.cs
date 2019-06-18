using System;
using System.Collections.Generic;
using System.Text;


namespace Servicos.Eletricos.Core.Domain.ValueObjects
{
    public class CPF
    {
        public const int TamanhoMaximo = 11;
        public string Codigo { get; private set; }
        public string DataExpedicao { get; private set; }
        public string EstadoExpedicao { get; private set; }

        public CPF(string cpf)
        {
            Codigo = cpf;
        }

        public static bool ValidarNumero(string cpf)
        {
            //Validação de número

            return true;

        }

        public string ObterCPF_Formatado()
        {
            int count = 1;
            string CodigoFormatado = "";
            var array = Codigo.ToCharArray();
            foreach (var num in array)
            {
                CodigoFormatado += num;
                if (count == 3)
                    CodigoFormatado += ".";
                else if (count == 6)
                    CodigoFormatado += ".";
                else if (count == 9)
                    CodigoFormatado += "-";
                count++;
            }
            return CodigoFormatado;
        }

    }
}
