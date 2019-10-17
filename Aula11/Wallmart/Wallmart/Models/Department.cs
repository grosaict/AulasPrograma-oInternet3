using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wallmart.Models
{
    //[Table("Departamentos")]
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        //public int DepartmentId { get; set; }
        //[Key]
        //public int MeuID { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage ="Max 10 caracteres"), MinLength(3)]
        public string Name { get; set; }

        [Url]
        public string Site { get; set; }

        [Display(Name= "Customer Satisfaction")]
        [Range(10, 100)]
        public int CustomerSatisfaction { get; set; }

        public ICollection<Seller> Sellers { get; set; }
            = new List<Seller>();

        public Department()
        {
        }

        public Department(string name, string site, int customerSatisfaction)
        {
            Name = name;
            Site = site;
            CustomerSatisfaction = customerSatisfaction;
        }

        public Department(int id, string name, string site, int customerSatisfaction)
        {
            Id = id;
            Name = name;
            Site = site;
            CustomerSatisfaction = customerSatisfaction;
        }

        public void AddSaller(Seller Seller) {
            Sellers.Add(Seller);
        }

        public double TotalSales(
            DateTime initial, DateTime final) {
            //Vamos usar o LINQ

            return Sellers.Sum(seller => seller.TotalSales(initial, final));

        }
    }
}
