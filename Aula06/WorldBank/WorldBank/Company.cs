using System;
using System.Collections.Generic;
using System.Text;

namespace WorldBank
{
    class Company : Persona
    {
        public Customer[] Partners { get; set; }
        public int CNPJ { get; set; }
        public string CompanyName { get; set; }
        public string TradingName { get; set; }
        public int StateRegister { get; set; }
        public DateTime Opening { get; set; }
        public double Revenue { get; set; }

        public Company
            (
                string address,
                string phone,
                string email,
                Customer[] partners,
                int cnpj,
                string companyName,
                string tradingName,
                int stateRegister,
                DateTime opening,
                double revenue
            )
            : base
            (
                  address,
                  phone,
                  email
            )
        {
            Partners        = partners;
            CNPJ            = cnpj;
            CompanyName     = companyName;
            TradingName     = tradingName;
            StateRegister   = stateRegister;
            Opening         = opening;
            Revenue         = revenue;
        }
    }
}
