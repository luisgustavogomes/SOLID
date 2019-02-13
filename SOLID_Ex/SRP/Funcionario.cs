using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.SRP
{
    public class Funcionario
    {
        public double SalarioBase { get; private set; }

        public Funcionario(double salarioBase)
        {
            SalarioBase = salarioBase;
        }
    }
}
