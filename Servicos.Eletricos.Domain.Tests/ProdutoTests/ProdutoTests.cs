using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Servicos.Eletricos.Cadastro.Domain.Produtos;
using Servicos.Eletricos.Cadastro.Domain.Categoria;

namespace Servicos.Eletricos.Domain.Cadastro.Tests.ProdutoTests
{
    public class ProdutoTests
    {
        //Obetivo: fornecer dois objetos com parametros obrigatórios porém vazios e com zeros e retornar validações diferentes

        [Fact(DisplayName = "Testar objetos com retornos de validações diferentes")]
        [Trait("Teste 1", "Teste 2")]
        public void Produto_CriacaoObjetos_DeveRetornarObjetosComValidacoesDiferentes()
        {

            //Arrange

            CategoriaSistema categoriasSistemas = new CategoriaSistema(Guid.NewGuid(), "Cerca Eletrica", DateTime.Now, true);

            //Parametros forçados para testar validações.: tipo unidade, quantidade, valorcompra, porcentagem
            var produto1 = new Produto(Guid.NewGuid(), "Camera 01", DateTime.Now, "", 0, "LG", 0, "",categoriasSistemas, "", 0);
            //Parametros forçados para testar validações.: descricao, tipo unidade, quantidade, valorcompra, porcentagem
            var produto2 = new Produto(Guid.NewGuid(), "", DateTime.Now, "", 0, "LG", 0,"" ,categoriasSistemas, "", 0);

            //Act

            //Assert

        }

        [Fact(DisplayName = "Deve retornar valor venda como 0")]
        public void Produto_RetornarValorVenda_DeveRetornarZero()
        {
            var categoriasSistemas = new CategoriaSistema(Guid.NewGuid(), "Cerca Eletrica", DateTime.Now, true);

            //////Arrange
            var produto = new Produto(Guid.NewGuid(), "", DateTime.Now, "Peça", 0, "LG", 0, "",categoriasSistemas, "", 0, true);

            //////Act
            decimal valorVenda = produto.RetornarValorVenda();

            //////Assert
            Assert.Equal(0, valorVenda);
        }

        [Fact(DisplayName = "Deve retornar valor venda igual a compra com porcentagem 0")]
        public void Produto_VerificarValorVenda_DeveRetornarvalorAcimaDeZeroComQuantidadeZero()
        {
            var categoriasSistemas = new CategoriaSistema(Guid.NewGuid(), "Cerca Eletrica", DateTime.Now, true);

            ////Arrange
            var produto = new Produto(Guid.NewGuid(), "", DateTime.Now, "Peça",2, "LG", 350,"",categoriasSistemas,"",0,true);

            ////Act
            decimal valorVenda = produto.RetornarValorVenda();

            ////Assert
            Assert.Equal(350, valorVenda);
        }

        [Fact(DisplayName = "Deve retornar valor venda acima de zero com quantidade 2")]
        public void Produto_VerificarValorVenda_DeveRetornarvalorAcimaDeZeroComQuantidadeAcimaDeZero()
        {
            //decimal teste = 0.02m;

            ////Arrange
            //produto = new Produto(Guid.NewGuid(), "", DateTime.Now, "", 2, "", "", 350,0,0.2m);

            ////Act
            //decimal valorVenda = produto.RetornarValorVenda();

            ////Assert
            //Assert.Equal(840, valorVenda);
        }



    }
}
