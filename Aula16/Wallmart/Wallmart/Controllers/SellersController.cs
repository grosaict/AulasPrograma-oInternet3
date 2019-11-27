using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wallmart.Models;
using Wallmart.Models.ViewModels;
using Wallmart.Services;

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
                return NotFound();
            }

            //Testar sem fazer o teste de null
            //Tenta buscar o registro desse vendedor
            var obj = _sellerService.FindById(id.Value);

            //Verifico se o id era válido, ou seja
            //se havia um vendedor com esse id

            if (obj == null) {
                //Vendedor não encontrado, retorna página
                //de não encontrado
                return NotFound();
            }
            //Retorna o vendedor para o delete.cshtml
            return View(obj);
        }


        [HttpPost]
        public IActionResult Delete(int id) {
            _sellerService.Remove(id);
            return RedirectToAction("Index");

        }

        /* Copiado o Método DELETE e ajustado conforme a necessidade*/
        public IActionResult Details(int? id)
        {
            //testar com !id
            //Verifico se o usuário tentou acessar a url
            //sem indicar o id
            if (id == null)
            {
                return NotFound();
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
                return NotFound();
            }
            //Retorna o vendedor para o delete.cshtml
            return View(obj);
        }

        /* Copiado o Método Details e ajustado conforme a necessidade*/
        public IActionResult Edit(int? id)
        {
            //testar com !id
            //Verifico se o usuário tentou acessar a url sem indicar o id
            if (id == null)
            {
                return NotFound();
            }

            //Testar sem fazer o teste de null
            //Tenta buscar o registro desse vendedor
            var obj = _sellerService.FindById(id.Value);

            //Verifico se o id era válido, ou seja, se havia um vendedor com esse id

            if (obj == null)
            {
                //Vendedor não encontrado, retorna página de não encontrado
                return NotFound();
            }

            // Copiado do Create e adaptado às necessidades desse método
            List<Department> departments = _departmentService.FindAll();
            //Criar uma instância de SellerFormViewModel, que vai conter
            //duas propriedades, a primeira é o lista de departamentos e
            //a outra será o Seller.

            var viewModel =
                new SellerFormViewModel
                {
                    Seller = obj,
                    Departments = departments
                };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(int? id, SellerFormViewModel viewModel)
        {
            // Verifica se o campo id do formulário não foi alterado pelo usuário
            if (viewModel.Seller.Id != id)
            {
                return BadRequest();
            }
            _sellerService.Update(viewModel.Seller);
            return RedirectToAction("Index");
        }
    }
}