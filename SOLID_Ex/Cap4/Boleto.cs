﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.Cap4
{
    public class Boleto
    {
        public double Valor { get; private set; }

        public Boleto(double valor)
        {
            Valor = valor;
        }
    }
}
