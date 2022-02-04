using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaWeb.Models;
using sistemaWeb.Models.Enum;

namespace sistemaWeb.Data
{
    public class SeedingService
    {
        private sistemaWebContext _context;

        public SeedingService (sistemaWebContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if( _context.Departamento.Any() ||
                _context.Vendedor.Any()     ||
                _context.RegistroVendas.Any())
            {
                return; //banco de dados ja populado
            }

            Departamento d1 = new Departamento(1, "Eletronicos");
            Departamento d2 = new Departamento(2, "Computadores");
            Departamento d3 = new Departamento(3, "Livros");
            Departamento d4 = new Departamento(4, "Moveis");

            Vendedor v1 = new Vendedor(1, "Dione", "dione@email.com", new DateTime(1993, 09, 05), 2250.00, d1);
            Vendedor v2 = new Vendedor(2, "Toni", "toni@email.com", new DateTime(1989, 12, 09), 4200.00, d4);
            Vendedor v3 = new Vendedor(3, "Maria", "maria@email.com", new DateTime(1991, 12, 01), 2250.00, d2);
            Vendedor v4 = new Vendedor(4, "Suelen", "suelen@email.com", new DateTime(1997, 03, 06), 2250.00, d1);
            Vendedor v5 = new Vendedor(5, "Sergio", "sergio@email.com", new DateTime(1982, 02, 10), 2250.00, d3);
            Vendedor v6 = new Vendedor(6, "Emerson", "emerson@email.com", new DateTime(1993, 11, 12), 2250.00, d3);

            RegistroVenda r1 = new RegistroVenda(1, new DateTime(2022, 01, 02), 1500.00, StatusVenda.Pendente, v2);
            RegistroVenda r2 = new RegistroVenda(2, new DateTime(2022, 01, 02), 3500.00, StatusVenda.Finalizada, v1);
            RegistroVenda r3 = new RegistroVenda(3, new DateTime(2022, 01, 02), 500.00, StatusVenda.Finalizada, v1);
            RegistroVenda r4 = new RegistroVenda(4, new DateTime(2018, 09, 1), 8000.0, StatusVenda.Finalizada, v1);
            RegistroVenda r5 = new RegistroVenda(5, new DateTime(2018, 09, 21), 3000.0, StatusVenda.Finalizada, v3);
            RegistroVenda r6 = new RegistroVenda(6, new DateTime(2018, 09, 15), 2000.0, StatusVenda.Finalizada, v1);
            RegistroVenda r7 = new RegistroVenda(7, new DateTime(2018, 09, 28), 13000.0, StatusVenda.Finalizada, v2);
            RegistroVenda r8 = new RegistroVenda(8, new DateTime(2018, 09, 11), 4000.0, StatusVenda.Finalizada, v4);
            RegistroVenda r9 = new RegistroVenda(9, new DateTime(2018, 09, 14), 11000.0, StatusVenda.Pendente, v6);
            RegistroVenda r10 = new RegistroVenda(10, new DateTime(2018, 09, 7), 9000.0, StatusVenda.Finalizada, v6);
            RegistroVenda r11 = new RegistroVenda(11, new DateTime(2018, 09, 13), 6000.0, StatusVenda.Finalizada, v2);
            RegistroVenda r12 = new RegistroVenda(12, new DateTime(2018, 09, 25), 7000.0, StatusVenda.Pendente, v3);
            RegistroVenda r13 = new RegistroVenda(13, new DateTime(2018, 09, 29), 10000.0, StatusVenda.Finalizada, v4);
            RegistroVenda r14 = new RegistroVenda(14, new DateTime(2018, 09, 4), 3000.0, StatusVenda.Finalizada, v5);
            RegistroVenda r15 = new RegistroVenda(15, new DateTime(2018, 09, 12), 4000.0, StatusVenda.Finalizada, v1);
            RegistroVenda r16 = new RegistroVenda(16, new DateTime(2018, 10, 5), 2000.0, StatusVenda.Finalizada, v4);
            RegistroVenda r17 = new RegistroVenda(17, new DateTime(2018, 10, 1), 12000.0, StatusVenda.Finalizada, v1);
            RegistroVenda r18 = new RegistroVenda(18, new DateTime(2018, 10, 24), 6000.0, StatusVenda.Finalizada, v3);
            RegistroVenda r19 = new RegistroVenda(19, new DateTime(2018, 10, 22), 8000.0, StatusVenda.Finalizada, v5);
            RegistroVenda r20 = new RegistroVenda(20, new DateTime(2018, 10, 15), 8000.0, StatusVenda.Finalizada, v6);
            RegistroVenda r21 = new RegistroVenda(21, new DateTime(2018, 10, 17), 9000.0, StatusVenda.Finalizada, v2);
            RegistroVenda r22 = new RegistroVenda(22, new DateTime(2018, 10, 24), 4000.0, StatusVenda.Finalizada, v4);
            RegistroVenda r23 = new RegistroVenda(23, new DateTime(2018, 10, 19), 11000.0, StatusVenda.Cancelada, v2);
            RegistroVenda r24 = new RegistroVenda(24, new DateTime(2018, 10, 12), 8000.0, StatusVenda.Finalizada, v5);
            RegistroVenda r25 = new RegistroVenda(25, new DateTime(2018, 10, 31), 7000.0, StatusVenda.Finalizada, v3);
            RegistroVenda r26 = new RegistroVenda(26, new DateTime(2018, 10, 6), 5000.0, StatusVenda.Finalizada, v4);
            RegistroVenda r27 = new RegistroVenda(27, new DateTime(2018, 10, 13), 9000.0, StatusVenda.Pendente, v1);
            RegistroVenda r28 = new RegistroVenda(28, new DateTime(2018, 10, 7), 4000.0, StatusVenda.Finalizada, v3);
            RegistroVenda r29 = new RegistroVenda(29, new DateTime(2018, 10, 23), 12000.0, StatusVenda.Finalizada, v5);
            RegistroVenda r30 = new RegistroVenda(30, new DateTime(2018, 10, 12), 5000.0, StatusVenda.Finalizada, v2);

            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);

            _context.RegistroVendas.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13,
                                             r14,r15,r16,r17,r18,r19,r20,r21,r22,r23,r24,r25,r26,r27,r28,r29,r30);
            _context.SaveChanges();
        }
    }
}
