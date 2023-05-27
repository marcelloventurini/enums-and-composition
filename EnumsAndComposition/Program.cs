using EnumsAndComposition.Entities;
using EnumsAndComposition.Entities.Enums;

Console.WriteLine("Informe os dados do cliente: ");
Console.Write("Nome: ");
string name = Console.ReadLine();

Console.Write("Email: ");
string email = Console.ReadLine();

Console.Write("Data de nascimento (MM/DD/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Informe os dados do pedido: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new(name, email, birthDate);
Order order = new(DateTime.Now, status, client);

Console.Write("Quantos itens serão adicionados ao pedido? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Informe os dados do {i + 1}o item:");
    Console.Write("Nome do produto: ");
    string productName = Console.ReadLine();

    Console.Write("Preço do produto: ");
    double productPrice = double.Parse(Console.ReadLine());

    Console.Write("Quantidade: ");
    int productAmount = int.Parse(Console.ReadLine());

    Product product = new(productName, productPrice);
    OrderItem orderItem = new(productAmount, productPrice, product);

    order.AddItem(orderItem);
}

Console.WriteLine("Resumo do pedido:");
Console.WriteLine(order);
