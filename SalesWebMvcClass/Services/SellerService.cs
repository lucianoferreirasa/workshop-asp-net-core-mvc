using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvcClass.Data;
using SalesWebMvcClass.Models;

namespace SalesWebMvcClass.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcClassContext _context;

        public SellerService(SalesWebMvcClassContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }


    }
}
