using System;
using System.Collections.Generic;
using System.Text;

namespace WorldBank
{
    abstract class Persona
    {
        public int ID { get; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Persona(string address, string phone, string email)
        {
            Address = address;
            Phone   = phone;
            Email   = email;
        }
    }
}
