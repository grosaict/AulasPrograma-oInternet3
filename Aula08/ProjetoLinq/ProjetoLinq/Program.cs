using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoLinq.Entities;

namespace ProjetoLinq
{
    class Program
    {
        static void Print<T> (string message, IEnumerable<T> list)
        {
            Console.WriteLine(message);
            foreach (T item in list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("----");
        }

        static void Main(string[] args)
        {
            // Creating Categories
            Category C1 = new Category() { Id = 1, Name = "Eletronics", Type = 1 };
            Category C2 = new Category() { Id = 2, Name = "Computers", Type = 1 };
            Category C3 = new Category() { Id = 3, Name = "Furnitures", Type = 2 };

            // Creating Products
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Laptop Lenovo", Price = 3000, Category = C2 },
                new Product() { Id = 2, Name = "Laptop HP", Price = 1800, Category = C2 },
                new Product() { Id = 3, Name = "Laptop Acer", Price = 2200, Category = C2 },
                new Product() { Id = 4, Name = "iPod", Price = 1000, Category = C1 },
                new Product() { Id = 5, Name = "Moto G7", Price = 1900, Category = C1 },
                new Product() { Id = 6, Name = "Table", Price = 400, Category = C3 },
                new Product() { Id = 7, Name = "Nichtstand", Price = 100, Category = C3 },
            };

            var r0 = products.Where(p => p.Price > 2200);
            Console.WriteLine("Resultado r0");
            // Show r0s
            /*foreach (Product item in specificProduct)
            {
                Console.WriteLine(item.ToString());
            }*/
            Print("Produtos com preço > 2200", r0);



            var r1 = products.Where(p => p.Category.Type == 2 && p.Price > 100);
            Console.WriteLine("Resultado r1");
            // Show r1s
            /*foreach (Product item in r1)
            {
                Console.WriteLine(item.ToString());
            }*/
            Print("Produtos com categoria = 2 e preço > 100", r1);



            var r2 = products.Where(p => p.Category.Name == "Eletronics").Select(p => p.Name);
            Console.WriteLine("Resultado r2");
            // Show r2s
            Print("Produtos com categoria = Eletronics (SOMENTE NOME)", r2);



            // Creating an anonymous object - object of a nonexistent class (new { p.Name, p.Price })
            // Creating an alias for a variable (CategoryName = p.Category.Name)
            var r3 = products.Where(p => p.Name[0] == 'L').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("Produtos que começam com a letra L", r3);



            var r4 = products.Where(p => p.Category.Type == 1).OrderBy(p => p.Price);
            Print("Produtos categoria tipo = 1 e ordenados pelo preço", r4);



            var r5 = products.OrderBy(p => p.Name);
            Print("Produtos ordenados pelo nome", r5);


            var r6 = products.OrderBy(p => p.Category.Name).ThenBy(p => p.Price);
            Print("Produtos ordenados pela categoria e pelo preço", r6);



            var r7 = products.FirstOrDefault();
            Console.WriteLine("Primeiro produto da lista: "+ r7 + "\n----");


            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Produto com ID = 3: " + r8 + "\n----");
        }
    }
}
