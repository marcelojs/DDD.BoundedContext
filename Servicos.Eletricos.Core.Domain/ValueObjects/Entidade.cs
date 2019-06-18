using Servicos.Eletricos.Core.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Core.Domain.ValueObjects
{
    public class Entidade
    {
        public Entidade()
        {
            
        }

        public Guid AnalisarId(Guid id)
        {
            if (id != Guid.Empty)
                return id;
            else
                return Guid.NewGuid();
        }

        public bool EhValido()
        {
            //verificação de ValidationResult será feita 
            return    true;
        }
    }
}
