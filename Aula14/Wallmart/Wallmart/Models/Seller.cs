using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wallmart.Models
{
    public class Seller
    {
        /*[DatabaseGenerated(DatabaseGeneratedOption.None)]*/
        public int Id { get; set; }

        [MinLength(3, ErrorMessage ="Min 3 caracteres")]
        [MaxLength(20, ErrorMessage = "Max 20 caracteres")]
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<SalesRecord> SalesRecords
        { get; set; } = new List<SalesRecord>();

        public Seller(){}

        public Seller(int id, string name, string email, DateTime birthDate, double salary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Salary = salary;
            Department = department;
        }

        public Seller(string name, string email, DateTime birthDate, double salary, Department department)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Salary = salary;
            Department = department;
        }

        public Seller(string name, string email, DateTime birthDate, double salary, int departmentId)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Salary = salary;
            DepartmentId = departmentId;
        }

        public void AddSales(SalesRecord sr) {
            SalesRecords.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            SalesRecords.Remove(sr);
        }

        public double TotalSales(
            DateTime initial, DateTime final){
            //Usar o LINQ para filtrar a lista de vendas com lambda
            return SalesRecords.Where(
                sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
