using System;
using Domain.Model;
namespace Model.Domain
{
    public class Mesa
    {
        const int MAXQUANT = 10;
        private int quantidadeItensVendidos = 0;
        public int Numero { get; private set; }
        public Item[] Itens { get;}  = new Item[MAXQUANT];

        public Mesa(int numero)
        {
            Numero = numero;
        }

        public void RegistrarItem(Item item)
        {
            if (quantidadeItensVendidos < MAXQUANT)
                Itens[quantidadeItensVendidos++] = item;
        }
    }
}
