using Servicos.Eletricos.Cadastro.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Domain.Servicos.Services
{
    public class ServicoService : IServicoService
    {
        private readonly IServicoRepository _servicoRepository;

        public ServicoService(IServicoRepository servicoRepository)
        {
            _servicoRepository = servicoRepository;
        }

        public Servico Adicionar(Servico servico)
        {
            if (servico.EhValido())
            {
                servico.AdicionarIdentidade();
                _servicoRepository.Adicionar(servico);
            }
            else
                return servico;

            return servico;
        }

        public Servico Atualizar(Servico servico)
        {
            if (servico.EhValido())
                _servicoRepository.Atualizar(servico);
            else
                return servico;

            return servico;
        }

        public void InativarServico(Guid servicoId)
        {
            var servico =  _servicoRepository.ObterPorId(servicoId);
            servico.Inativar();
            _servicoRepository.Atualizar(servico);
        }

        public Servico ObterPorCodigo(string codigo)
        {
            return _servicoRepository.ObterPorCodigo(codigo);
        }

        public Servico ObterPorDescricao(string descricao)
        {
            return _servicoRepository.ObterPorDescricao(descricao);
        }

        public Servico ObterPorId(Guid id)
        {
            return _servicoRepository.ObterPorId(id);
        }
    }
}
