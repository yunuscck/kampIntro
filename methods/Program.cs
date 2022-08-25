
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
product1.Stock = 3;

Product product2= new Product();
product2.Name = "Karpuz";
product2.Price = 80;
product2.Description = "Diyarbakır karpuzu";
product2.Stock = 5;

Product[] products = new Product[] { product1, product2 };

foreach (Product product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Description);
    Console.WriteLine("-----------------------------");

}

Console.WriteLine("-------------Metotlar-------------");

SepetManager sepetManager = new SepetManager();
sepetManager.Add(product1);
sepetManager.Add(product2);

sepetManager.Add2("armut", "yeşil", 12, 3);
sepetManager.Add2("elma", "kırmızı", 12, 4);
sepetManager.Add2("karpuz", "diyarbakır", 12, 5);





