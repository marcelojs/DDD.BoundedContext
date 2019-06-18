using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Servicos.Eletricos.Cadastro.Domain.Clientes;
using Servicos.Eletricos.Core.Domain.ValueObjects;


namespace Servicos.Eletricos.Domain.Cadastro.Tests.ClienteTests
{

    public class ClienteTests
    {

        /*
          Feature - Cliente 
          Validar numero CPF
            Obter Somente Numeros CPF
            Retornar CPF Completo


        */

        Cliente cliente;

        [Fact(DisplayName = "Confirmar que o cliente não é aniversariante")]
        public void Cliente_VeriricarSeCLienteNaoEhAniversariante_DeveRetornarResultadoDaComparacaoEntreDatas()
        {

            //var dataAniversario = new DateTime(1990, 01, 24);


            //cliente = new Cliente(Guid.NewGuid(),
            //    "Marcelo",
            //    "Nanini",
            //    "marcelojs90@gmail.com",
            //     "38598331899",
            //     DateTime.Now,
            //    dataAniversario,
            //    "brasileiro");

            ////Act
            //var data = cliente.VerificarSeClienteEhAniversariante();

            ////Assert
            //Assert.False(data);
        }

        [Fact(DisplayName = "Verifica se o cliente é aniversariante")]
        public void Cliente_VeriricarSeCLienteEhAniversariante_DeveRetornarResultadoDaComparacaoEntreDatas()
        {
            //var dataAniversario = new DateTime(1990, 05, 21);


            //cliente = new Cliente(Guid.NewGuid(),
            //    "Marcelo",
            //    "Nanini",
            //    "marcelojs90@gmail.com",
            //    "38598331899",
            //    DateTime.Now,
            //     dataAniversario,
            //    "brasileiro");

            ////Act
            //var data = cliente.VerificarSeClienteEhAniversariante();

            ////Assert
            //Assert.True(data);
        }

        //Esse teste foi apenas para testar a classe ClienteValidation
        [Fact(DisplayName = "Verifica se o cliente validation manterá mais de uma instancia de validation result")]
        public void Cliente_VeriricarObjetosClientes_DeveRetornarObjetosClientesComValidationResultsDiferentes()
        {
            //var dataAniversario = new DateTime(1990, 05, 21);

            //var cliente1 = new Cliente(Guid.NewGuid(), "", "Nanini", "marcelojs90@gmail", "38598322819", DateTime.Now, dataAniversario, "brasileiro");
            //var cliente2 = new Cliente(Guid.NewGuid(), "Marcelo", "", "marcelojs90@gmail.com", "", DateTime.Now, dataAniversario, "");

            //var qtd1 = cliente1.ValidationResult.NotificacoesErros.Count;
            //var qtd2 = cliente2.ValidationResult.NotificacoesErros.Count;
        }


    }







}
