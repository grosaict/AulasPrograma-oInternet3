using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallmart.Models;
using Wallmart.Services.Exceptions;

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
            //return _context.Seller.Include(obj => obj.Department).Include(obj => obj.Department).FirstOrDefault(s => s.Id == id);
            //Testar Auto referência
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

        public void Update(Seller obj) {
            /*Verifica se há algum vendedor no banco com esse Id*/
            if (_context.Seller.Any(s => s.Id == obj.Id))
            {

                try
                {
                    /*Atualiza o registro do vendedor na tabela Seller */
                    _context.Update(obj);
                    _context.SaveChanges();
                }
                /*Esse erro é do entity framework, ou seja,
                 da camada de acesso aos dados*/
                catch (DbUpdateConcurrencyException e)
                {
                    throw new DbConcurrencyException(e.Message);
                }
            }
            else {
                throw new NotFoundException("ID not found");
            }
        }


    }
}
