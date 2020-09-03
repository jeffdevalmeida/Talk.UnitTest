using System;
using System.Collections.Generic;
using System.Text;

namespace Talk.Domain.Context.Entities
{
    public class PedidoItem : Entity
    {
        public PedidoItem(Produto product, int quantity)
        {
            Produto = product;
            Quantidade = quantity;
            if (product.QuantidadeEstoque < quantity)
                AddNotification("Quantity", "Product out of stock!");

            product.RetirarQuantidadeEmEstoque(quantity);

        }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Preco { get; private set; }
    }
}
