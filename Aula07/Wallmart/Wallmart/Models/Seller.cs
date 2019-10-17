using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wallmart.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [MaxLength(10, ErrorMessage = "Máximo 10"), MinLength(3, ErrorMessage = "Mínimo 3")]
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birth { get; set; }
        public double Payment { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> SalesRecords { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }
    }
}
