using sistemaWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaWeb.Services
{
    public class RegistroVendaService
    {
        private readonly sistemaWebContext _context;

        public RegistroVendaService( sistemaWebContext context)
        {
            _context = context;
        }

        public async Task<List<RegistroVenda>> ObterPorDataAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.RegistroVendas select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }

            return await result.Include(x => x.Vendedor)
                        .Include(x => x.Vendedor.Departamento)
                        .OrderByDescending(x => x.Data)
                        .ToListAsync();
        }

        public async Task<List<IGrouping<Departamento, RegistroVenda>>> ObterPorDataGrupoAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.RegistroVendas select obj; 
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }

            return await result
                        .Include(x => x.Vendedor)
                        .Include(x => x.Vendedor.Departamento)
                        .OrderByDescending(x => x.Data)
                        .GroupBy(x => x.Vendedor.Departamento)
                        .ToListAsync();
        }
    }
}
