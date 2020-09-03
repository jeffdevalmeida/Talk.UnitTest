using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Talk.Domain.Context.Enums;

namespace Talk.Domain.Context.Entities
{
    public class Pedido : Entity
    {
        private readonly IList<PedidoItem> _itens;

        public Cliente Cliente { get; private set; }
        public string Numero { get; private set; }
        public EPedidoStatus Status { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public IReadOnlyCollection<PedidoItem> Itens => _itens.ToArray();

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            DataCriacao= DateTime.Now;
            _itens = new List<PedidoItem>();
            Status = EPedidoStatus.Criado;
        }

        public void AddItem(Produto product, int quantity)
        {
            if (quantity > product.QuantidadeEstoque)
                AddNotification("OrderItem", $"Produto {product.Titulo} does not have {quantity} itens in stock!");

            var item = new PedidoItem(product, quantity);
            _itens.Add(item);
        }

        public void Create()
        {
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            if (_itens.Count == 0)
                AddNotification("Order", "This order does not have itens");
        }

        public void Cancel()
        {
            Status = EPedidoStatus.Cancelado;
        }

    }
}
