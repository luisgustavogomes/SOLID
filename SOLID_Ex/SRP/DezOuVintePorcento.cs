using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.SRP
{
    public class DezOuVintePorcento : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            return funcionario.SalarioBase > 3000 ? funcionario.SalarioBase * 0.8 : funcionario.SalarioBase * 0.9;
        }
    }
}
