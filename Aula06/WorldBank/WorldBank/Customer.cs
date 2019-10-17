using System;
using System.Collections.Generic;
using System.Text;

namespace WorldBank
{
    class Customer : Persona
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Document { get; set; }
        public string CPF { get; set; }
        public DateTime Birth { get; set; }
        public int Age { get; }
        public string AgeRange { get; }
        public double Income { get; set; }

        public Customer
            (
                string address,
                string phone,
                string email,
                string name,
                string surname,
                string document,
                string cpf,
                DateTime birth,
                double income
            )
            : base
            (
                  address,
                  phone,
                  email
            )
        {
            Name        = name;
            Surname     = surname;
            Document    = document;
            CPF         = cpf;
            Birth       = birth;
            Income      = income;

            SharedMethods s = new SharedMethods();
            Age             = s.Age(birth);
            AgeRange        = s.AgeRange(Age);
        }
    }
}
