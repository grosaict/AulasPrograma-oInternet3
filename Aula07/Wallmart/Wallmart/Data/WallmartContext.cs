using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wallmart.Models
{
    public class WallmartContext : DbContext
    {
        public WallmartContext (DbContextOptions<WallmartContext> options)
            : base(options)
        {
        }

        public DbSet<Wallmart.Models.Department> Department { get; set; }
    }
}
