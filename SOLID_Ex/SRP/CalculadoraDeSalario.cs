using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.SRP
{
    class CalculadoraDeSalario : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            return funcionario.Cargo.Regra.Calcula(funcionario);
        }
    }
}
