using Servicos.Eletricos.Cadastro.Application.ViewModels;
using Servicos.Eletricos.Cadastro.Domain.Categoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Eletricos.Cadastro.Application.Adapters
{
    public class CategoriaSistemaAdapter
    {
        public static CategoriaSistema ToDomain(CategoriaSistemaViewModel categoriaSistemasViewModel)
        {
            var CategoriaSistema = new CategoriaSistema(
                categoriaSistemasViewModel.CategoriaId,
                categoriaSistemasViewModel.Descricao,
                categoriaSistemasViewModel.DataCadastro,
                categoriaSistemasViewModel.Ativo
                );

            return CategoriaSistema;
        }

        public static CategoriaSistemaViewModel ToViewModel(CategoriaSistema categoriasSistemas)
        {
            var categoriaSistemasViewModel = new CategoriaSistemaViewModel()
            {
                CategoriaId = categoriasSistemas.CategoriaId,
                DataCadastro = categoriasSistemas.DataCadastro,
                Ativo = categoriasSistemas.Ativo,
                Descricao = categoriasSistemas.Descricao
            };

            return categoriaSistemasViewModel;
        }

        public static List<CategoriaSistemaListViewModel> ToViewModelList(List<CategoriaSistema> categoriasSistemas)
        {
            List<CategoriaSistemaListViewModel> categoriaSistemasListViewModels = new List<CategoriaSistemaListViewModel>();

            foreach (var categoria in categoriasSistemas)
            {
                categoriaSistemasListViewModels.Add(new CategoriaSistemaListViewModel(
                    categoria.CategoriaId, categoria.Descricao, categoria.Ativo));
            }

            return categoriaSistemasListViewModels;
        }
    }
}
