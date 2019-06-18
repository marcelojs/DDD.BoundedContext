using Servicos.Eletricos.Core.Domain.Notification;
using Servicos.Eletricos.Core.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Domain.Categoria
{
    public static class CategoriaSistemaValidation
    {

        public static string VerificarSeCategoriaSistemaEhValido(this CategoriaSistema categoriasSistemas, string descricao)
        {
             bool retorno = AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertArgumentNotEmpty(descricao, "Descrição não pode ser vazio"),
                AssertionConcern.AssertArgumentNotNull(descricao, "Descrição não pode ser nulo"));

            InserirNotificacoes(categoriasSistemas,"Descrição", AssertionConcern.Notifications);

            return retorno == true ? descricao  : "";
        }

        private static void InserirNotificacoes(this CategoriaSistema categoriasSistemas, string Tipo, List<DomainNotification> domainNotifications)
        {
            var _validationResult = new ValidationResult();

            foreach (var domainNotification in domainNotifications)
            {
                _validationResult.NotificacoesErros.Add(new ErrorNotification(Tipo, domainNotification.Valor));
            }
        }

    }
}
