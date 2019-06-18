using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;

using Servicos.Eletricos.Cadastro.Domain.Clientes;
using Servicos.Eletricos.Cadastro.Domain.Clientes.Intefaces;
using Servicos.Eletricos.Cadastro.Domain.Clientes.Services;


namespace Servicos.Eletricos.Domain.Cadastro.Tests.ClienteTests.Service
{
    public class ClienteServieTests
    {

        //Objetivo desse teste é recusar cliente inválido e recusar enderecos caso sejam inválidos
        [Fact(DisplayName = "Deve recusar cliente inválido e recusar enderecos caso sejam inválidos. Obs (Cliente novo)")]
        public void ClienteService_Adicionar_DeveRecusarClienteEEnderecosInvalidosERetornarNotificacoes()
        {
            //Arrange
            //Inválidos.: email, cpf (2 erros), nacionalidade
            var idCliente = Guid.Empty;

            var endereco1 = new Endereco(Guid.Empty, 75, "Centro", "Sorocaba", "SP", "rua teste 1", "Prédio Comercial", "18016358",null);
            var endereco2 = new Endereco(Guid.Empty, 188, "Santa Rosália", "Sorocaba", "SP", "rua teste 2", "Casa", "180167899",null);
            var endereco3 = new Endereco(Guid.Empty, 12, "Campolim", "Sorocaba", "SP", "rua teste 3", "Loja Shopping", "18016789966",null);

            var cliente1 = new Cliente(Guid.Empty, "Marcelo", "José Nanini", "", null);
            cliente1.AdicionarEndereco(endereco1);
            cliente1.AdicionarEndereco(endereco2);
            cliente1.AdicionarEndereco(endereco3);

            var repo = new Mock<IClienteRepository>();
            repo.Setup(r => r.ObterPorId(idCliente)).Returns(cliente1);

            var clienteService = new ClienteService(repo.Object);

            //Act
            clienteService.Adicionar(cliente1);

            //Assert
            Assert.Equal(4,cliente1.ValidationResult.NotificacoesErros.Count);
            //Assert.Single(endereco1.ValidationResult.NotificacoesErros);
            Assert.Single(endereco2.ValidationResult.NotificacoesErros);
            Assert.Single(endereco3.ValidationResult.NotificacoesErros);

        }

        //Objetivo desse teste é persistir o cliente válido e recusar enderecos caso sejam inválidos
        [Fact(DisplayName = "Deve persistir o cliente válido e recusar enderecos caso sejam inválidos. Obs (Cliente novo)")]
        public void ClienteService_Adicionar_DevePersistirClienteEEnderecosCasoSejamValidosERetornarNotificacoes()
        {
            //Arrange
            //Inválidos.: email, cpf (2 erros), nacionalidade
            var idCliente = Guid.Empty;

            DateTime dataNascimento = new DateTime(1990, 01, 24);

            var endereco1 = new Endereco(Guid.Empty, 75, "Centro", "Sorocaba", "SP", "rua teste 1", "Prédio Comercial", "18016358", null);
            var endereco2 = new Endereco(Guid.Empty, 188, "Santa Rosália", "Sorocaba", "SP", "rua teste 2", "Casa", "180167899", null);
            var endereco3 = new Endereco(Guid.Empty, 12, "Campolim", "Sorocaba", "SP", "rua teste 3", "Loja Shopping", "18016789966", null);

            var cliente1 = new Cliente(Guid.Empty, "Marcelo", "José Nanini", "38598331899", null, dataNascimento);
            cliente1.AdicionarEndereco(endereco1);
            cliente1.AdicionarEndereco(endereco2);
            cliente1.AdicionarEndereco(endereco3);

            var repo = new Mock<IClienteRepository>();
            repo.Setup(r => r.ObterPorId(idCliente)).Returns(cliente1);

            var clienteService = new ClienteService(repo.Object);

            //Act
            clienteService.Adicionar(cliente1);

            //Assert
            Assert.Equal(4, cliente1.ValidationResult.NotificacoesErros.Count);
            //Assert.Single(endereco1.ValidationResult.NotificacoesErros);
            Assert.Single(endereco2.ValidationResult.NotificacoesErros);
            Assert.Single(endereco3.ValidationResult.NotificacoesErros);

        }

    }
}
