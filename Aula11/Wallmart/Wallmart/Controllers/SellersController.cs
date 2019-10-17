using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wallmart.Models;
using Wallmart.Models.ViewModels;
using Wallmart.Service;

namespace Wallmart.Controllers
{
    public class SellersController : Controller
    {
        // Injeção de dependência do serviço de acesso aos dados de vendedores e de departamentos
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        // Construtor para finalizar a injeção de dependência
        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService      = sellerService;
            _departmentService  = departmentService;
        }


        public IActionResult Index()
        {
            //ICollection<Seller> Sellers = new List<Seller>();
            //id, string name, string email, DateTime birthDate, double salary, Department department)
            //Sellers.Add(new Seller(1, "Ana", "ana@ana.com", new DateTime(2019, 01,25), 8789.6, new Department()));
            //return View(Sellers);

            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            // Carrega os departamentos utilizando o serviço de acesso aos dados de Departments
            var departments = _departmentService.FindAll();

            // Instancia SellerFormViewModel, que vai conter duas propriedades (1ª é a lista de departamentos e a 2ª será o Seller)
            var viewModel = new SellerFormViewModel { Departments = departments };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(Seller obj)
        {
            _sellerService.Insert(obj);
            return RedirectToAction("Index");
        }
    }
}