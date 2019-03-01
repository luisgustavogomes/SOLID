using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.SRP
{
    public class Dba : Cargo
    {
        public Dba(IRegraDeCalculo regraDeCalculo) : base(regraDeCalculo)
        {
        }
    }
}
