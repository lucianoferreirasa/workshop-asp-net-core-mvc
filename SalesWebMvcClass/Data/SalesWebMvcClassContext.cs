using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcClass.Models;

namespace SalesWebMvcClass.Data
{
    public class SalesWebMvcClassContext : DbContext
    {
        public SalesWebMvcClassContext (DbContextOptions<SalesWebMvcClassContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvcClass.Models.Department> Department { get; set; }
    }
}
