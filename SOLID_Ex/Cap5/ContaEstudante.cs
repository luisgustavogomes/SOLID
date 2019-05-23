using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.Cap5
{
    public class ContaEstudante : ContaComum
    {
        public Int32 Milhas { get; private set; }

        public override void Deposita(double valor)
        {
            base.Deposita(valor);
            Milhas += (Int32)valor;
        }

        public override void SomaInvestimento()
        {
            throw new Exception("Não soma milhas"); 
        }
    }
}
