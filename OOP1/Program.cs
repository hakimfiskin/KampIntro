using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 499.99;
            product1.UnitInStock = 500;

            Product product2 = new Product {Id = 2, CategoryID = 5, UnitInStock = 300, ProductName = "Kalem", UnitPrice = 29.99};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

        }
    }
}
