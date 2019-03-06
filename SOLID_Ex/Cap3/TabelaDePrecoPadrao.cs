﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.Cap3
{
    public class TabelaDePrecoPadrao : ITabelaDePreco
    {
        public TabelaDePrecoPadrao()
        {
        }

        public double DescontoPara(double valor)
        {
            if (valor > 5000) return 0.03;
            if (valor > 1000) return 0.05;
            return 0;
        }
    }
}