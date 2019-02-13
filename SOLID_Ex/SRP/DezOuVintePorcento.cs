using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.SRP
{
    public class DezOuVintePorcento : TemplateRegraDeCalculo
    {
        public DezOuVintePorcento(double faixaSalarial = 3000, double taxaMaxima = 0.9, double taxaMinima = 0.8) : base(faixaSalarial, taxaMaxima, taxaMinima) {}
    }
}
