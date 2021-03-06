using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sistemaWeb.Models
{
    public class sistemaWebContext : DbContext
    {
        public sistemaWebContext (DbContextOptions<sistemaWebContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<RegistroVenda> RegistroVendas { get; set; }
    }
}
