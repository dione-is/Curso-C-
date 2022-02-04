﻿using System;
using System.Collections.Generic;
using System.Globalization;
using sistemaWeb.Models.Enum;

namespace sistemaWeb.Models
{
    public class RegistroVenda
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public double Valor { get; set; }

        public StatusVenda Status { get; set; }

        public Vendedor Vendedor { get; set; }

        public RegistroVenda()
        {

        }

        public RegistroVenda(int id, DateTime data, double valor, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
