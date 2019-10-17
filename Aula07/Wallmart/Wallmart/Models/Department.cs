using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wallmart.Models
{
    //[Table("Departamentos")]
    public class Department
    {
        public int Id { get; set; }
        //[Key]
        //public int DepartmentId { get; set; }
        [Required]
        [MaxLength(8, ErrorMessage = "Máximo 8"), MinLength(3, ErrorMessage = "Mínimo 3")]
        public string Name { get; set; }
        [Url]
        public string Site { get; set; }
        [Display(Name = "Customer Satisfaction")]
        [Range(10, 100)]
        public string CustomerSatisfaction { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }
    }
}
