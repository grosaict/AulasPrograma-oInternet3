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

        public Seller FindById(int id)
        {
            // retorna o vendedor do o ID recebido por parâmetro
            return _context.Seller.FirstOrDefault(s => s.Id == id);

            /* _context é a conexão com o banco
             * FirstOrDefault é uma função que irá buscar o valor passado no banco
             * s => cria um objeto identico ao registro do banco
             * s.Id acessa o campo Id do registro
             * == id compara o valor anterior com o id passado por parâmetro
             * Quando encontrado, retorna o registro inteiro
             * Senão retorna NULL que é a característica do OrDefault da função
             */
        }

        public void Remove(int id)
        {
            // Cria uma instância de Seller para apontar para o registro que quero remover
            var seller = _context.Seller.Find(id);

            // em tese faz o mesmo que o comando anterior
            // var seller = FindById(id);

            // Remove o objeto do banco de dados
            _context.Seller.Remove(seller);

            // Confirmar a transação de exclusão do registro ao EntityFramework para persistir a alteração
            _context.SaveChanges();
        }
    }
}
