using SalesWebMvcClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvcClass.Models;

namespace SalesWebMvcClass.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcClassContext _context;

        public DepartmentService(SalesWebMvcClassContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
