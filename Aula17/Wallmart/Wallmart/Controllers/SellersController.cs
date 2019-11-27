using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wallmart.Models;
using Wallmart.Models.ViewModels;
using Wallmart.Services;
using Wallmart.Services.Exceptions;

namespace Wallmart.Controllers
{
    public class SellersController : Controller
    {   //Injeção de depêndencia do serviço de acesso aos
        //dados de vendedores e também de departamentos
        private readonly SellerService _sellerService;

        private readonly DepartmentService _departmentService;

        //Construtor para finalizar a injeção de dependência
        public SellersController(SellerService sellerService, DepartmentService departmentService) {
            _sellerService = sellerService;
            _departmentService = departmentService;
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

        public IActionResult Create(){
            //Carrega os departamentos, utilizando o serviço de acesso
            //aos dados de departamentos

            var departments = _departmentService.FindAll();
            //Criar uma instância de SellerFormViewModel, que vai conter
            //duas propriedades, a primeira é o lista de departamentos e
            //a outra será o Seller.

            var viewModel =
                new SellerFormViewModel { Departments = departments };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(SellerFormViewModel obj)
        {

            Seller slr = obj.Seller;
            _sellerService.Insert(slr);
            return RedirectToAction("Index");
        }

        /*Notem que o parâmetro Id é opcional
         para indicar que um parâmetro é opcional, basta
         usar o símbolo de '?' após o tipo da variável*/
        public IActionResult Delete(int? id) {
            //testar com !id
            //Verifico se o usuário tentou acessar a url
            //sem indicar o id
            if (id == null) {
                //return NotFound();
                return RedirectToAction("Error", 
                    new { message = "Id not provided"});
            }

            //Testar sem fazer o teste de null
            //Tenta buscar o registro desse vendedor
            var obj = _sellerService.FindById(id.Value);

            //Verifico se o id era válido, ou seja
            //se havia um vendedor com esse id

            if (obj == null) {
                //Vendedor não encontrado, retorna página
                //de não encontrado
                //return NotFound();
                return RedirectToAction("Error",
                    new { message = "This Seller doesn't exist" });
            }
            //Retorna o vendedor para o delete.cshtml
            return View(obj);
        }


        [HttpPost]
        public IActionResult Delete(int id) {
            _sellerService.Remove(id);
            return RedirectToAction("Index");

        }

        /*Notem que o parâmetro Id é opcional
        para indicar que um parâmetro é opcional, basta
        usar o símbolo de '?' após o tipo da variável*/
        public IActionResult Details(int? id)
        {
            //testar com !id
            //Verifico se o usuário tentou acessar a url
            //sem indicar o id
            if (id == null)
            {
                return RedirectToAction("Error",
                    new { message = "Id not provided" });
            }

            //Testar sem fazer o teste de null
            //Tenta buscar o registro desse vendedor
            var obj = _sellerService.FindById(id.Value);

            //Verifico se o id era válido, ou seja
            //se havia um vendedor com esse id

            if (obj == null)
            {
                //Vendedor não encontrado, retorna página
                //de não encontrado
                //return NotFound();
                return RedirectToAction("Error",
                    new { message = "Seller not avaiable" });
            }
            //Retorna o vendedor para o delete.cshtml
            return View(obj);
        }


        public IActionResult Edit(int? id)
        {
            //testar com !id
            //Verifico se o usuário tentou acessar a url
            //sem indicar o id
            if (id == null)
            {
                //return NotFound();
                return RedirectToAction("Error",
                    new { message = "Id not provided" });
            }

            //Testar sem fazer o teste de null
            //Tenta buscar o registro desse vendedor
            var obj = _sellerService.FindById(id.Value);

            //Verifico se o id era válido, ou seja
            //se havia um vendedor com esse id

            if (obj == null)
            {
                //Vendedor não encontrado, retorna página
                //de não encontrado
                //return NotFound();
                return RedirectToAction("Error",
                    new { message = "Id not Found" });
            }

            List<Department> departments = _departmentService.FindAll();

            SellerFormViewModel viewModel =
                new SellerFormViewModel
                {
                    Seller = obj,
                    Departments = departments
                };
            
            return View(viewModel);
        }


        [HttpPost]
        public IActionResult Edit(int? id, 
            SellerFormViewModel viewModel) {
            /*Verifica se o campo id do formulário 
             * não foi alterado pelo usuário*/
            if (viewModel.Seller.Id != id) {
                //return BadRequest();
                return RedirectToAction("Error",
                    new { message = "Id missmatch" });
            }


            try {
                _sellerService.Update(viewModel.Seller);
                return RedirectToAction("Index");
            }
            catch (ApplicationException e) {

                return RedirectToAction("Error",
                    new { message = e.Message });
            }



            

           
        }

        public IActionResult Error(string message) {

            var viewModel = new ErrorViewModel{
                Message = message,
                RequestId = 
                Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }


    }
}