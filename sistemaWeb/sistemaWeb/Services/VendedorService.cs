using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaWeb.Models;
using Microsoft.EntityFrameworkCore;
using sistemaWeb.Services.Exceptions;

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

        public Vendedor ObterPeloId(int id)
        {
            return _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remover(int id)
        {
            var obj = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();
        }

        public void Atualizar (Vendedor obj)
        {
            if(!_context.Vendedor.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundExceptions("id não existe");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch(DbConcurrencyExceptions e)
            {
                throw new DbConcurrencyExceptions(e.Message);
            }
        }
    }
}
