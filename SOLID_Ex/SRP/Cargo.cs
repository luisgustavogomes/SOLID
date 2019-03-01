using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.SRP
{
    public abstract class Cargo
    {
        public IRegraDeCalculo Regra { get; set; }

        protected Cargo(IRegraDeCalculo regraDeCalculo)
        {
            Regra = regraDeCalculo;
        }
    }
}
