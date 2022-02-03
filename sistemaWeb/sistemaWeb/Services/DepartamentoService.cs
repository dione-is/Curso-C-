using sistemaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace sistemaWeb.Services
{
    public class DepartamentoService
    {
        private readonly sistemaWebContext _context;

        public DepartamentoService(sistemaWebContext context)
        {
            _context = context;
        }

        public List<Departamento> ObterTodos()
        {
            return _context.Departamento.OrderBy(dep => dep.Nome).ToList();
        }
    }
}
