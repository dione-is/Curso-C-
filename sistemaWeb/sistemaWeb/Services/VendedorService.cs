using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaWeb.Models;

namespace sistemaWeb.Services
{
    public class VendedorService
    {
        private readonly sistemaWebContext _context;

        public VendedorService(sistemaWebContext context)
        {
            _context = context;
        }
        
        public List<Vendedor> ObterTodos()
        {
            return _context.Vendedor.ToList();
        }

        public void Inserir(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
