using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wallmart.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }
        public SalesRecord()
        {
        }
    }
}
