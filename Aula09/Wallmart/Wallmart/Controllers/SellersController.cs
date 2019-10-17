using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wallmart.Models;

namespace Wallmart.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            ICollection<Seller> Sellers = new List<Seller>();
            //id, string name, string email, DateTime birthDate, double salary, Department department)
            Sellers.Add(new Seller(1, "Ana", "ana@ana.com", new DateTime(2019, 01,25), 8789.6, new Department()));
            return View(Sellers);
        }
    }
}