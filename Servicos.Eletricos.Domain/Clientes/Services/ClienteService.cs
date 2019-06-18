using Servicos.Eletricos.Cadastro.Domain.Clientes.Intefaces;
using Servicos.Eletricos.Cadastro.Domain.Clientes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Domain.Clientes.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) {
            _clienteRepository = clienteRepository;
        }


        public Cliente Adicionar(Cliente cliente)
        {
            if (cliente.EhValido())
            {
                cliente.AdicionarIdentidade();
                _clienteRepository.Adicionar(cliente);
            }
            else
                return cliente;

            foreach(var endereco in cliente.Enderecos)
            {
                if (endereco.EhValido())
                {
                    endereco.AdicionarIdentidade();
                    endereco.VincularEnderecoAoCliente(cliente.ClienteID);
                    _clienteRepository.AdicionarEndereco(endereco);
                }
            }
            
            return cliente;
        }

        public Cliente Atualizar(Cliente cliente)
        {
            if (cliente.EhValido())
                _clienteRepository.Atualizar(cliente);
            else
                return cliente;

            return cliente;
        }

        public Cliente ObterPorCPF(string cpf)
        {
            return _clienteRepository.ObterPorCPF(cpf);
        }

        public Cliente ObterPorEmail(string email)
        {
            return _clienteRepository.ObterPorEmail(email);
        }

        public Cliente ObterPorId(Guid id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public List<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }


        public Endereco AdicionarEndereco(Endereco endereco)
        {
            if (endereco.EhValido())
            {
                endereco.AdicionarIdentidade();
                _clienteRepository.AdicionarEndereco(endereco);
            }

            return endereco;
        }

        public Endereco AtualizarEndereco(Endereco endereco)
        {
            if (endereco.EhValido())
                _clienteRepository.AtualizarEndereco(endereco);
            return endereco;
        }

        public void DeletarEndereco(Guid enderecoId)
        {
            _clienteRepository.DeletarEndereco(enderecoId);
        }

      
    }
}
