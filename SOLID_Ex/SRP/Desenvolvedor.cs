using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.SRP
{
    public class Desenvolvedor : Cargo
    {
        public Desenvolvedor(IRegraDeCalculo regraDeCalculo) : base(regraDeCalculo)
        {
        }
    }
}
