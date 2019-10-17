using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;    // Necessário para utilizar a função Display


namespace primeiro_projeto_pi3.Models
{
    public class Department
    {
        [Display(Name = "Code")]                // Substitui a expressão IdDepartment por Code no nome da coluna
        public int IdDepartment { get; set; }
        [Display(Name = "Description")]         // Substitui a expressão Name por Description no nome da coluna
        public string Name { get; set; }
    }
}
