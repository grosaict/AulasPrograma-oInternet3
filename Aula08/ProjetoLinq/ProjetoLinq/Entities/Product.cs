using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLinq.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return  "ID: " + Id + 
                    " Name: " + Name + 
                    " Price: " + Price + 
                    " Category: " + Category.Name;
        }
    }
}
