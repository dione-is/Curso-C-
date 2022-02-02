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

            RegistroVendas r1 = new RegistroVendas(1, new DateTime(2022, 01, 02), 1500.00, StatusVenda.Pendente, v2);
            RegistroVendas r2 = new RegistroVendas(2, new DateTime(2022, 01, 02), 3500.00, StatusVenda.Finalizada, v1);
            RegistroVendas r3 = new RegistroVendas(3, new DateTime(2022, 01, 02), 500.00, StatusVenda.Finalizada, v1);
            RegistroVendas r4 = new RegistroVendas(4, new DateTime(2018, 09, 1), 8000.0, StatusVenda.Finalizada, v1);
            RegistroVendas r5 = new RegistroVendas(5, new DateTime(2018, 09, 21), 3000.0, StatusVenda.Finalizada, v3);
            RegistroVendas r6 = new RegistroVendas(6, new DateTime(2018, 09, 15), 2000.0, StatusVenda.Finalizada, v1);
            RegistroVendas r7 = new RegistroVendas(7, new DateTime(2018, 09, 28), 13000.0, StatusVenda.Finalizada, v2);
            RegistroVendas r8 = new RegistroVendas(8, new DateTime(2018, 09, 11), 4000.0, StatusVenda.Finalizada, v4);
            RegistroVendas r9 = new RegistroVendas(9, new DateTime(2018, 09, 14), 11000.0, StatusVenda.Pendente, v6);
            RegistroVendas r10 = new RegistroVendas(10, new DateTime(2018, 09, 7), 9000.0, StatusVenda.Finalizada, v6);
            RegistroVendas r11 = new RegistroVendas(11, new DateTime(2018, 09, 13), 6000.0, StatusVenda.Finalizada, v2);
            RegistroVendas r12 = new RegistroVendas(12, new DateTime(2018, 09, 25), 7000.0, StatusVenda.Pendente, v3);
            RegistroVendas r13 = new RegistroVendas(13, new DateTime(2018, 09, 29), 10000.0, StatusVenda.Finalizada, v4);
            RegistroVendas r14 = new RegistroVendas(14, new DateTime(2018, 09, 4), 3000.0, StatusVenda.Finalizada, v5);
            RegistroVendas r15 = new RegistroVendas(15, new DateTime(2018, 09, 12), 4000.0, StatusVenda.Finalizada, v1);
            RegistroVendas r16 = new RegistroVendas(16, new DateTime(2018, 10, 5), 2000.0, StatusVenda.Finalizada, v4);
            RegistroVendas r17 = new RegistroVendas(17, new DateTime(2018, 10, 1), 12000.0, StatusVenda.Finalizada, v1);
            RegistroVendas r18 = new RegistroVendas(18, new DateTime(2018, 10, 24), 6000.0, StatusVenda.Finalizada, v3);
            RegistroVendas r19 = new RegistroVendas(19, new DateTime(2018, 10, 22), 8000.0, StatusVenda.Finalizada, v5);
            RegistroVendas r20 = new RegistroVendas(20, new DateTime(2018, 10, 15), 8000.0, StatusVenda.Finalizada, v6);
            RegistroVendas r21 = new RegistroVendas(21, new DateTime(2018, 10, 17), 9000.0, StatusVenda.Finalizada, v2);
            RegistroVendas r22 = new RegistroVendas(22, new DateTime(2018, 10, 24), 4000.0, StatusVenda.Finalizada, v4);
            RegistroVendas r23 = new RegistroVendas(23, new DateTime(2018, 10, 19), 11000.0, StatusVenda.Cancelada, v2);
            RegistroVendas r24 = new RegistroVendas(24, new DateTime(2018, 10, 12), 8000.0, StatusVenda.Finalizada, v5);
            RegistroVendas r25 = new RegistroVendas(25, new DateTime(2018, 10, 31), 7000.0, StatusVenda.Finalizada, v3);
            RegistroVendas r26 = new RegistroVendas(26, new DateTime(2018, 10, 6), 5000.0, StatusVenda.Finalizada, v4);
            RegistroVendas r27 = new RegistroVendas(27, new DateTime(2018, 10, 13), 9000.0, StatusVenda.Pendente, v1);
            RegistroVendas r28 = new RegistroVendas(28, new DateTime(2018, 10, 7), 4000.0, StatusVenda.Finalizada, v3);
            RegistroVendas r29 = new RegistroVendas(29, new DateTime(2018, 10, 23), 12000.0, StatusVenda.Finalizada, v5);
            RegistroVendas r30 = new RegistroVendas(30, new DateTime(2018, 10, 12), 5000.0, StatusVenda.Finalizada, v2);

            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);

            _context.RegistroVendas.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13,
                                             r14,r15,r16,r17,r18,r19,r20,r21,r22,r23,r24,r25,r26,r27,r28,r29,r30);
            _context.SaveChanges();
        }
    }
}
