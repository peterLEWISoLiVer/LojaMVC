using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaMVC.Models;
namespace LojaMVCTests
{
    public class ClienteTests
    {
        [Fact]
        public void idade_menor_que_zero()
        {    //Arrange - Preparação
               var cliente = new Cliente
            {
                id_cliente = 1,
                nome_cliente = "clovis",
                idade_cliente = 17,
                email_cliente = "clovis@gmail.com",
                status_cliente = "ativo"
            };
            //Act - Teste
            var resultado = cliente.clientValidation();
            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void email_invalido_verifica()
        {    //Arrange - Preparação
            var cliente = new Cliente
            {
                id_cliente = 1,
                nome_cliente = "clovis",
                idade_cliente = 17,
                email_cliente = "clovisgmail.com",
                status_cliente = "ativo"
            };
            //Act - Teste
            var resultado = cliente.clientValidation();
            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void nome_em_branco()
        {    //Arrange - Preparação
            var cliente = new Cliente
            {
                id_cliente = 1,
                nome_cliente = "",
                idade_cliente = 17,
                email_cliente = "clovis@gmail.com",
                status_cliente = "ativo"
            };
            //Act - Teste
            var resultado = cliente.clientValidation();
            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void cliente_inativo_bloqueia()
        {    //Arrange - Preparação
            var cliente = new Cliente
            {
                id_cliente = 1,
                nome_cliente = "clovis",
                idade_cliente = 17,
                email_cliente = "clovis@gmail.com",
                status_cliente = "inativo"
            };
            //Act - Teste
            var resultado = cliente.canBuying() ;
            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void cliente_apto_mas_menor_de_idade()
        {    //Arrange - Preparação
            var cliente = new Cliente
            {
                id_cliente = 1,
                nome_cliente = "clovis",
                idade_cliente = 17,
                email_cliente = "clovis@gmail.com",
                status_cliente = "ativo"
            };
            //Act - Teste
            var resultado = cliente.credentialsValidation();
            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void cliente_apto_mas_sem_email()
        {    //Arrange - Preparação
            var cliente = new Cliente
            {
                id_cliente = 1,
                nome_cliente = "clovis",
                idade_cliente = 18,
                email_cliente = "",
                status_cliente = "ativo"
            };
            //Act - Teste
            var resultado = cliente.credentialsValidation();
            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void cliente_apto_para_comprar()
        {    //Arrange - Preparação
            var cliente = new Cliente
            {
                id_cliente = 1,
                nome_cliente = "clovis",
                idade_cliente = 22,
                email_cliente = "clovis@gmail.com",
                status_cliente = "ativo"
            };
            //Act - Teste
            var resultado = cliente.clientValidation() && cliente.canBuying();
            //Assert
            Assert.True(resultado);
        }

    }
}
