﻿using System;
using System.Collections.Generic;
using System.Globalization;
using sistemaWeb.Models.Enum;

namespace sistemaWeb.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public double Valor { get; set; }

        public StatusVenda_ Status { get; set; }

        public Vendedor Vendedor { get; set; }

        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime data, double valor, StatusVenda_ status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
