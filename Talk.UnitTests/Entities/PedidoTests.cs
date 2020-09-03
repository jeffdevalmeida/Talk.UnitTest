using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Talk.Domain.Context.Entities;
using Talk.Domain.Context.Enums;
using Talk.Domain.Context.ValueObjects;

namespace Talk.UnitTests.Entities
{
    public class PedidoTests
    {
        private Produto _monitor;
        private Produto _carregador;
        private Produto _lixeira;
        private Cliente _cliente;
        private Pedido _pedido;

        [SetUp]
        public void Setup()
        {
            var name = new NomeVo("Jeff", "Almeida");
            var email = new EmailVo("jefferson.almeida@konia.com.br");

            _monitor = new Produto("Monitor", 50M, 3);
            _carregador = new Produto("Carregador", 50M, 5);
            _lixeira = new Produto("Lixeira", 50M, 1);

            _cliente = new Cliente(name, email);
            _pedido = new Pedido(_cliente);
        }

        [Test]
        public void PedidoTests_CriarPedido_Valido_ReturnTrue()
        {
            Assert.AreEqual(true, _pedido.Valid);
        }

        [Test]
        public void OrderTests_CreateOrder_WhenCreated_Status_Is_Created()
        {
            Assert.AreEqual(EPedidoStatus.Criado, _pedido.Status);
        }

        [Test]
        public void OrderTests_CreateOrder_Order_Item_Must_be_2()
        {
            _pedido.AddItem(_monitor, 5);
            _pedido.AddItem(_carregador, 5);

            Assert.AreEqual(2, _pedido.Itens.Count);
        }
    }
}
