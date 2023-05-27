using System.Text;

namespace EnumsAndComposition.Entities
{
    internal class OrderItem
    {
        public int Amount { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int amount, double price, Product product)
        {
            Amount = amount;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Amount * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, R${Price}, Quantidade: {Amount}, SubTotal: R${SubTotal()}";
        }
    }
}
