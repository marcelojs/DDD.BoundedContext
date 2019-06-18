using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Servicos.Eletricos.Cadastro.Domain.Produtos;
using Servicos.Eletricos.Cadastro.Domain.Categoria;
using Moq;
using Servicos.Eletricos.Cadastro.Domain.Produtos.Interfaces;
using Servicos.Eletricos.Cadastro.Domain.Produtos.Services;

namespace Servicos.Eletricos.Domain.Cadastro.Tests.ProdutoTests.Service
{
    public class ProdutoServiceTests
    {
        [Fact(DisplayName = "Deve retornar objeto com valor de venda calculado")]
        public void ProdutoService_Adicionar_DeveRetornarObjetoComValorDeVendaCalculado() {
            
            // valor unit 400
            // porcenta.. 15%

            // 400 * 0,15 = 60 ; 400 + 60 = 460
            

            //Arrange
            Guid idCategoria = Guid.NewGuid();
            Guid idProduto = Guid.NewGuid();

            var categoriasSistemas = new CategoriaSistema(idCategoria, "Sistema de Cameras", DateTime.Now,true);
            var produto = new Produto(
                idProduto, 
                "Camera Seguranca HLX 3000", 
                DateTime.Now, 
                "Peça", 
                3,
                "HLX",
                400,"",
                categoriasSistemas, null,0.15M, true);

            var repo = new Mock<IProdutoRepository>();
            repo.Setup(r => r.ObterPorId(idProduto)).Returns(produto);
            var produtoService = new ProdutoService(repo.Object);

            //Act
            produtoService.Adicionar(produto);

            //Assert
            Assert.Equal(460, produto.ValorVenda);


        }


    }
}
