using Servicos.Eletricos.Cadastro.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.Interfaces
{
    public interface IClienteAppService
    {
        ClienteViewModel Adicionar(ClienteViewModel clienteViewModel);
        ClienteViewModel Atualizar(ClienteViewModel clienteViewModel);
        ClienteViewModel ObterCliente(Guid clienteId);
        List<ClienteListViewModel> ObterTodos();

        EnderecoViewModel AdicionarEndereco(EnderecoViewModel endereco);
        EnderecoViewModel AtualizarEndereco(EnderecoViewModel endereco);
        void DeletarEndereco(Guid enderecoId);
        List<EnderecoListViewModel> ObterTodosEnderecos();
    }
}
