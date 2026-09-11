using LojaMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMVCTests
{
    public class ProdutoTests
    {
        [Fact]
        public void  valor_produto_Maior_que_Zero()
        {
            //Arrange - Preparação
            var produto = new Produto
            {
                nome_produto = "Mouse",
                preco_produto = 0,
                estoque_produto = 50,
            };
            //Act - Teste
            var resultado = produto. produtoValidation();

            //Assert - Verificação
            Assert.False(resultado);
            
        }

        [Fact]
        public void estoque_invalido_quando_for_negativo()
        {
            //Arrange
            var produto = new Produto
            {
                nome_produto = "Teclado",
                preco_produto = 50,
                estoque_produto = -1,
            };
            //Act
            var resultado = produto. produtoValidation();
           //Assert
            Assert.False(resultado);

        }

        [Fact]
        public void nome_invalido_se_vazio_ou_nulo()
        {
            //Arrange
            var produto = new Produto
            {
                nome_produto = "",
                preco_produto = 50,
                estoque_produto = 1,
            };
            //Act
            var resultado = produto. produtoValidation();
            //Assert
            Assert.False(resultado);

        }

        [Fact]
        public void verificaNome_valido_verifica_preco_verifica_estoque_valido()
        {
            //Arrange
            var produto = new Produto
            {
                nome_produto = "Piano",
                preco_produto = 50,
                estoque_produto = 12,
            };
            //Act
            var resultado = produto. produtoValidation();
            //Assert
            Assert.True(resultado);

        }


    }
}
