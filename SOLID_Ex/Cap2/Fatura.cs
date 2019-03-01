using SOLID_Ex.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.Cap2
{
    public class Fatura
    {
        public double ValorMensal { get; private set; }

        public Fatura(double valorMensal)
        {
            ValorMensal = valorMensal;
        }
    }
}