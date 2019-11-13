using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallmart.Models;

namespace Wallmart.Services
{
    public class SellerService
    {
        /*declara um objeto que é o contexto do banco*/
        private readonly WallmartContext _context;

        public SellerService(WallmartContext context) {
            _context = context;
        }

        public List<Seller> FindAll() {
            /*Acessa a tabela Seller e transforma os
             registros em objetos e retorna como uma
             lista de objetos*/
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj) {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id) {
            //Retorna o vendedor com o ID passado por parâmetro
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(s => s.Id == id);
        }

        public void Remove(int id) {
            //Criar uma instância de Seller para apontar 
            //para o registro que quero remover
            var seller = _context.Seller.Find(id);
            //Remove o objeto do banco de dados
            _context.Seller.Remove(seller);
            //Confirmar a transação de exclusão do registro ao 
            //EntityFramework para persistir a alteração
            _context.SaveChanges();
        }


    }
}
