﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class CuentaBancaria
    {
        public int Id { get; set; }
        public string NumeroCuenta { get; set; }
        public double Saldo { get; set; }
        public string Tipo { get; set; }
        public Cliente Propietario { get; set; }

    }
}
