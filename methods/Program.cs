
using methods;
string productName = "elma";
double price = 15;
string description = "Amasya elması";

string productName2 = "elma";
double price2 = 15;
string description2 = "Amasya elması";

string[] meyveler = new string[] { };

Product product1= new Product();
product1.Name = "elma";
product1.Price = 15;
product1.Description = "Amasya elmsı";

Product product2= new Product();
product2.Name = "Karpuz";
product2.Price = 80;
product2.Description = "Diyarbakır karpuzu";

Product[] products = new Product[] { product1, product2 };

foreach (Product product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Description);
    Console.WriteLine("-----------------------------");

}












