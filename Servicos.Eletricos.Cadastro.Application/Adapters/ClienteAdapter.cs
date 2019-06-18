using Servicos.Eletricos.Cadastro.Application.ViewModels;
using Servicos.Eletricos.Cadastro.Domain.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.Adapters
{
    public class ClienteAdapter
    {
        //VERIFICAR FORMA DE RETORNAR COM AS VIEW MODELS AS VALIDAÇÕES FEITAS NO DOMINIO


        public static Cliente ToClienteDomain(ClienteViewModel clienteViewModel)
        {
            var cliente = new Cliente(
                clienteViewModel.ClienteID,
                clienteViewModel.Nome,
                clienteViewModel.Sobrenome,
                clienteViewModel.CPF,
                clienteViewModel.DataCadastro,
                clienteViewModel.DataNascimento,
                clienteViewModel.Email,
                clienteViewModel.Nacionalidade,
                clienteViewModel.Ativo,
                clienteViewModel.RG,
                clienteViewModel.Telefone,
                clienteViewModel.TelefoneCelular);

            return cliente;
        }

        public static ClienteViewModel ToClienteViewModel(Cliente cliente)
        {
            var clienteViewModel = new ClienteViewModel()
            {
                ClienteID = cliente.ClienteID,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                CPF = cliente.CPF.Codigo,
                DataCadastro = cliente.DataCadastro,
                DataNascimento = cliente.DataNascimento,
                Email = cliente.Email.Endereco,
                Nacionalidade = cliente.Nacionalidade,
                Ativo = cliente.Ativo,
                RG = cliente.RG,
                Telefone = cliente.Telefone,
                TelefoneCelular = cliente.TelefoneCelular
            };

            return clienteViewModel;
        }

        public static List<ClienteListViewModel> ToClienteListViewModel(List<Cliente> clientes)
        {
            List<ClienteListViewModel> ClientesViewModel = new List<ClienteListViewModel>();

            foreach (var cliente in clientes)
            {

                var clienteListViewModel = new ClienteListViewModel(
                    cliente.ClienteID,
                    cliente.Nome,
                    cliente.Sobrenome,
                    cliente.Ativo,
                    cliente.Nacionalidade,
                    cliente.CPF.Codigo,
                    cliente.Telefone,
                    cliente.TelefoneCelular);

                ClientesViewModel.Add(clienteListViewModel);
            }

            return ClientesViewModel;
        }


        public static EnderecoViewModel ToEnderecoViewModel(Endereco endereco)
        {
            var enderecoViewModel = new EnderecoViewModel()
            {
                EnderecoId = endereco.EnderecoId,
                ClienteId = endereco.ClienteId,
                Numero = endereco.Numero,
                Bairro = endereco.Cidade,
                Cidade = endereco.Estado,
                Logradouro = endereco.Logradouro,
                Complemento = endereco.Complemento,
                DataCadastro = endereco.DataCadastro,
                CEP = endereco.CEP.NumeroCep
            };

            return enderecoViewModel;
        }

        public static List<EnderecoViewModel> ToEnderecosViewModel(List<Endereco> enderecos)
        {
            List<EnderecoViewModel> enderecosViewModel = new List<EnderecoViewModel>();

            foreach (var endereco in enderecos)
                enderecosViewModel.Add(ToEnderecoViewModel(endereco));

            return enderecosViewModel;
        }

        public static Endereco ToEnderecoDomain(EnderecoViewModel enderecoViewModel)
        {
            var endereco = new Endereco(
                enderecoViewModel.EnderecoId,
                enderecoViewModel.Numero,
                enderecoViewModel.Bairro,
                enderecoViewModel.Cidade,
                enderecoViewModel.Estado,
                enderecoViewModel.Logradouro,
                enderecoViewModel.Complemento,
                enderecoViewModel.CEP,
                enderecoViewModel.DataCadastro,
                enderecoViewModel.ClienteId);

            return endereco;
        }

        public static List<Endereco> ToEnderecosDomain(List<EnderecoViewModel> enderecosViewModel)
        {
            List<Endereco> enderecos = new List<Endereco>();

            foreach (var enderecoViewModel in enderecosViewModel)
                enderecos.Add(ToEnderecoDomain(enderecoViewModel));

            return enderecos;
        }

        public static List<EnderecoListViewModel> ToEnderecoListViewModel(List<Endereco> enderecos)
        {

            List<EnderecoListViewModel> EnderecoListViewModels = new List<EnderecoListViewModel>();

            foreach (var endereco in enderecos)
            {

                var enderecoListViewModel = new EnderecoListViewModel(

                    endereco.EnderecoId,
                    endereco.Numero.ToString(),
                    endereco.Bairro,
                    endereco.Cidade,
                    endereco.Estado,
                    endereco.Logradouro,
                    endereco.Complemento,
                    endereco.CEP.NumeroCep);

                EnderecoListViewModels.Add(enderecoListViewModel);

            }

            return EnderecoListViewModels;

        }

    }
}
