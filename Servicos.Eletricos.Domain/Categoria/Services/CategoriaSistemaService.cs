using Servicos.Eletricos.Cadastro.Domain.Categoria.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Domain.Categoria.Services
{
    public class CategoriaSistemaService : ICategoriaSistemaService
    {
        private readonly ICategoriaSistemaRepository _categoriasSistemasRepository;

        public CategoriaSistemaService(ICategoriaSistemaRepository categoriasSistemasRepository)
        {
            _categoriasSistemasRepository = categoriasSistemasRepository;
        }

        public CategoriaSistema Adicionar(CategoriaSistema categoriasSistemas)
        {
            if (categoriasSistemas.EhValido())
                _categoriasSistemasRepository.Adicionar(categoriasSistemas);
            else
                return categoriasSistemas;

            return categoriasSistemas;
        }

        public CategoriaSistema Atualizar(CategoriaSistema categoriasSistemas)
        {
            if (categoriasSistemas.EhValido())
                _categoriasSistemasRepository.Atualizar(categoriasSistemas);
            else
                return categoriasSistemas;

            return categoriasSistemas;
        }

        public CategoriaSistema ObterPorDescricao(string descricao)
        {
            return _categoriasSistemasRepository.ObterPorDescricao(descricao);
        }

        public CategoriaSistema ObterPorId(Guid id)
        {
            return _categoriasSistemasRepository.ObterPorId(id);
        }

        public List<CategoriaSistema> ObterTodos()
        {
            return _categoriasSistemasRepository.ObterTodos();
        }

        public List<CategoriaSistema> ObterTodosPorCondicao()
        {
            return _categoriasSistemasRepository.ObterTodosPorCondicao();
        }

        public void Inativar(Guid categoriaSistemaId)
        {
            var categoria = ObterPorId(categoriaSistemaId);
            categoria.Inativar();
            _categoriasSistemasRepository.Atualizar(categoria);
        }
    }
}
