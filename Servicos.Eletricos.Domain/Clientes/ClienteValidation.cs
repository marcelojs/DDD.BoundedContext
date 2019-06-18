using System;
using System.Collections.Generic;
using System.Text;
using Servicos.Eletricos.Core.Domain.ValueObjects;
using Servicos.Eletricos.Core.Domain.Validation;
using Servicos.Eletricos.Core.Domain.Notification;
using FluentValidation;

namespace Servicos.Eletricos.Cadastro.Domain.Clientes
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {

        }

        public void ValidarNome()
        {
            RuleFor(c => c.Nome)
                .NotEmpty()
                .NotNull()
                .WithMessage("Por favor preencha o campo nome");
        }
        
    }
}
