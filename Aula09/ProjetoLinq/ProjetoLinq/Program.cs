using ProjetoLinq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoLinq
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> list) {
            Console.WriteLine(message);
            foreach (T item in list) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Criando as categorias
            Category c1 = new Category() { Id = 1, Name = "Eletronics", Type = 1 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Type = 1 };
            Category c3 = new Category() { Id = 3, Name = "Furnitures", Type = 2 };

            //Criando lista de produtos
            List<Product> products = new List<Product>()
            {
                new Product(){ Id=1, Name="Laptop Dell",
                    Price =1500.0, Category=c2},
                new Product(){ Id=2, Name="Laptop HP",
                    Price =900.0, Category=c2},
                new Product(){ Id=3, Name="Mac Book",
                    Price =20000.5, Category=c2},
                new Product(){ Id=4, Name="Ipod",
                    Price =2200.8, Category=c1},
                new Product(){ Id=5, Name="Motorola G7 Top",
                    Price =900.0, Category=c1},
                new Product(){ Id=6, Name="Table",
                    Price =50.0, Category=c3},
                new Product(){ Id=7, Name="Nightstand",
                    Price =30.0, Category=c3},
            };

            var specificProduct =
                products.Where(p => p.Price > 200.0);

            //Para cada item da minha lista filtrada specificProduct
            //foreach (Product item in specificProduct) {
            //Mostra os dados do item, que é um obj da classe Product
            //Console.WriteLine(item.ToString());
            //}

            Print("PRODUTOS COM PREÇO > $200", specificProduct);


            //var r1 = products.Where(p => p.Category.Type == 1
            //&& p.Price > 1500);

            var r1 = from p in products
                     where p.Category.Type == 1 &&
                     p.Price > 1500
                     select p;

            Print("PRODUTOS COM CATEGORIA DO TIPO 1 E VALOR " +
                "MAIOR QUE 1500", r1);



            //Retorna apenas o valor do atributo e 
            //não o objeto inteiro
            var r2 = products.Where(
                p => p.Category.Name == "Eletronics").
                Select(p => p.Name);

            Print("NOMES DOS PRODUTOS DE ELETRONICOS", r2);

            //Utilização de objetos anônimos - Objeto de uma
            //classe inexistente
            //Note que CategoryName é uma apelino/alias para
            //p.Category.Name
            /*var r3 = products.Where(p => p.Name[0] == 'L').
                Select(p => new {
                    p.Name, p.Price, CategoryName = p.Category.Name});*/

            var r3 = from p in products
                     where p.Name[0] == 'L'
                     select new {
                         p.Name,
                         p.Price,
                         CategoryName = p.Category.Name
            };

            Print("PRODUTOS QUE COMEÇAM COM LETRA L", r3);

            var r4 = products.Where(p => p.Category.Type == 1).
                OrderBy(p => p.Name);

            Print("Produtos da categoria do tipo 1," +
                " ordenados pelo nome", r4);

            /*var r5 = products.Where(p => p.Category.Type == 1).
                OrderBy(p => p.Price).ThenBy(p => p.Name);*/

            var r5 = from p in products
                     where p.Category.Type == 1
                     orderby p.Price
                     orderby p.Name
                     select p;

            Print("Produtos da categoria do tipo 1," +
                " ordenados pelo preço e então pelo nome", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("Primeiro produto da lista "+r6);

            var r7 = products.Where(p => p.Id == 1).
                SingleOrDefault();
            Console.WriteLine("Apenas um produto \n" + r7);

            var r8 = products.Max(p => p.Price);
            Console.WriteLine("Maior valor - Produto mais caro:\n" + r8);

            var r9 = products.Min(p => p.Price);
            Console.WriteLine(
                "Menor valor - Produto mais barato:\n" + r9);

            var r10 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine(
                "A soma dos preços dos produtos da categoria 1:\n" + r10);

            var r11 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine(
                "A média dos preços dos produtos da categoria 1:\n" + r11);

            var r12 = products.Where(p => p.Price > 50).Skip(2).Take(2);
            Print("Exemplo pula 2 e pega 2 ", r12);





        }
    }
}
