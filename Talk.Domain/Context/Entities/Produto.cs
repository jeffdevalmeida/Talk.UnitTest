using System;
using System.Collections.Generic;
using System.Text;

namespace Talk.Domain.Context.Entities
{
    public class Produto : Entity
    {
        public string Titulo { get; private set; }
        public decimal Preco { get; private set; }
        public int QuantidadeEstoque { get; private set; }

        public Produto(string titulo, decimal preco, int quantidadeEstoque)
        {
            Titulo = titulo;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public void RetirarQuantidadeEmEstoque(int quantidade) => QuantidadeEstoque -= quantidade;
    }
}
