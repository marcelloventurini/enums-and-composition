using EnumsAndComposition.Entities;

Console.WriteLine("Informe os dados do cliente: ");
Console.Write("Nome: ");
string name = Console.ReadLine();

Console.Write("Email: ");
string email = Console.ReadLine();

Console.Write("Data de nascimento (MM/DD/YYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Client client = new(name, email, birthDate);

