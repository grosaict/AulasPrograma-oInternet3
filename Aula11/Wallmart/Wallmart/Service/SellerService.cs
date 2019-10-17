using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallmart.Models;

namespace Wallmart.Service
{
    public class SellerService
    {
        // Declara um objeto que é o contexto do banco
        private readonly WallmartContext _context;

        public SellerService(WallmartContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            // Acessa a tabela Seller e transforma os registros em objetos e retorna como lista de objetos
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
