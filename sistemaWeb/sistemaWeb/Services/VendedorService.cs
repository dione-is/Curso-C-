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
        
        public async Task<List<Vendedor>> ObterTodosAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }

        public async Task InserirAsync(Vendedor obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task <Vendedor> ObterPeloIdAsync(int id)
        {
            return  await _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoverAsync(int id)
        {
            try
            {
                var obj = await _context.Vendedor.FindAsync(id);
                _context.Vendedor.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException e)
            {
                throw new IntegretyException("Não foi possivel remover vendedor, pois existem venda vinculadas");
            }
        }

        public async Task AtualizarAsync (Vendedor obj)
        {
            bool hasAny = await _context.Vendedor.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundExceptions("id não existe");
            }

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbConcurrencyExceptions e)
            {
                throw new DbConcurrencyExceptions(e.Message);
            }
        }
    }
}
