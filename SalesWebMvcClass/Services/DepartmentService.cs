using SalesWebMvcClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvcClass.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvcClass.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcClassContext _context;

        public DepartmentService(SalesWebMvcClassContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}