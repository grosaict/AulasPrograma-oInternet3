using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallmart.Models;

namespace Wallmart.Service
{
    public class DepartmentService
    {
        private readonly WallmartContext _context;

        public DepartmentService(WallmartContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            // Retorna todos os departamentos ordenados pelo nome
            return _context.Department.OrderBy(d => d.Name).ToList();
        }
    }
}
