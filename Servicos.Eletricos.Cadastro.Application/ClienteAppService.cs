using Servicos.Eletricos.Cadastro.Application.Adapters;
using Servicos.Eletricos.Cadastro.Application.Interfaces;
using Servicos.Eletricos.Cadastro.Application.ViewModels;
using Servicos.Eletricos.Cadastro.Domain.Clientes.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteService _clienteService;
        private readonly IClienteRepository _clienteRepository;

        public ClienteAppService(IClienteRepository clienteRepository, IClienteService clienteService)
        {
            this._clienteRepository = clienteRepository;
            this._clienteService = clienteService;
        }


        public ClienteViewModel Adicionar(ClienteViewModel clienteViewModel)
        {
            var clienteDomain = ClienteAdapter.ToClienteDomain(clienteViewModel);
            var enderecosDomain = ClienteAdapter.ToEnderecosDomain(clienteViewModel.Enderecos);

            clienteViewModel = null; // será limpo no adapter de cliente

            foreach (var endereco in enderecosDomain)
                clienteDomain.AdicionarEndereco(endereco);

            var clienteReturn = _clienteService.Adicionar(clienteDomain);
            clienteDomain = null;

            return ClienteAdapter.ToClienteViewModel(clienteReturn);
        }

        public ClienteViewModel Atualizar(ClienteViewModel clienteViewModel)
        {
            var cliente = _clienteService.Atualizar(ClienteAdapter.ToClienteDomain(clienteViewModel));
            clienteViewModel = null;
            return ClienteAdapter.ToClienteViewModel(cliente);
        }

        public ClienteViewModel ObterCliente(Guid clienteId)
        {
            return ClienteAdapter.ToClienteViewModel(_clienteRepository.ObterPorId(clienteId));
        }

        public List<ClienteListViewModel> ObterTodos()
        {
            return ClienteAdapter.ToClienteListViewModel(_clienteRepository.ObterTodos());
        }


        public EnderecoViewModel AtualizarEndereco(EnderecoViewModel enderecoViewModel)
        {
            var endereco = _clienteService.AtualizarEndereco(ClienteAdapter.ToEnderecoDomain(enderecoViewModel));
            return enderecoViewModel;
        }

        public EnderecoViewModel AdicionarEndereco(EnderecoViewModel enderecoViewModel)
        {
            var endereco = ClienteAdapter.ToEnderecoDomain(enderecoViewModel);
            enderecoViewModel = null;
            return ClienteAdapter.ToEnderecoViewModel(_clienteService.AdicionarEndereco(endereco));
        }

        public List<EnderecoListViewModel> ObterTodosEnderecos()
        {
           return ClienteAdapter.ToEnderecoListViewModel( _clienteRepository.ObterTodosEnderecos());
        }

        public void DeletarEndereco(Guid enderecoId)
        {
            _clienteService.DeletarEndereco(enderecoId);
        }

        
    }
}
