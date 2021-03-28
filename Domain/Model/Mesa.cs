<<<<<<< HEAD
using Domain.Model;
=======
using System;
using Domain.Model;
>>>>>>> f72bb6e5dd74d6d454aa2dbf9d7a49701834709a
namespace Model.Domain
{
    public class Mesa
    {
        const int MAXQUANT = 10;
        private int quantidadeItensVendidos = 0;
        public int Numero { get; private set; }
<<<<<<< HEAD
        public Item[] Itens { get; } = new Item[MAXQUANT];
=======
        public Item[] Itens { get;}  = new Item[MAXQUANT];
>>>>>>> f72bb6e5dd74d6d454aa2dbf9d7a49701834709a

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
