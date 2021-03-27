namespace Domain.Model
{
    public class Item
    {
        public string Nome { get; private set; }
        public int Quanidade { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public decimal SubTotal { get; private set; }
    }
}
