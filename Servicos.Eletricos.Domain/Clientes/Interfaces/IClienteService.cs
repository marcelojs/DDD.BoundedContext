using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Domain.Clientes.Intefaces
{
    public interface IClienteService
    {
        Cliente Adicionar(Cliente cliente);
        Cliente Atualizar(Cliente cliente);
        Cliente ObterPorId(Guid id);
        Cliente ObterPorCPF(string cpf);
        Cliente ObterPorEmail(string email);
        List<Cliente> ObterTodos();//Verificar trecho expression

        Endereco AdicionarEndereco(Endereco endereco);
        Endereco AtualizarEndereco(Endereco endereco);
        void DeletarEndereco(Guid enderecoId);

    }
}
