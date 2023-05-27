using EnumsAndComposition.Entities.Enums;
using System.Text;

namespace EnumsAndComposition.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("Momento do pedido: ");
            sb.AppendLine(Moment.ToString("MM/dd/yyyy hh:mm:ss"));
            sb.Append("Status do pedido: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Cliente: ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Itens do pedido:");

            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.Append("Preço total: R$");
            sb.AppendLine(Total().ToString());

            return sb.ToString();
        }
    }
}
