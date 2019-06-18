using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Servicos.Eletricos.Cadastro.Domain.Categoria;

namespace Servicos.Eletricos.Domain.Cadastro.Tests.CategoriasSistemasTests
{
    public class CategoriasSistemasTests
    {
        //Objetivo .: testar se está validando a descrição da categoria

        [Fact(DisplayName = "Verificar descricao da categoria com valor")]
        public void Categoria_ValidarDescricao_DeveCompararSeONomePassadoEhIgualAoNomeDoObjeto() {

            //Arrange
            var categoria = new CategoriaSistema(Guid.NewGuid(), "Cerca Eletrica", DateTime.Now, true);

            //Act já é feito no construtor

            //Assert
            Assert.Equal("Cerca Eletrica", categoria.Descricao);
        }

        [Fact(DisplayName = "Verificar descricao da categoria sem valor")]
        public void Categoria_ValidarDescricao_DeveReconhecerDescricaoVazio()
        {

            //Arrange
            var categoria = new CategoriaSistema(Guid.NewGuid(), "",DateTime.Now);

            //Act já é feito no construtor

            //Assert
            Assert.Equal("", categoria.Descricao);
        }


    }
}
