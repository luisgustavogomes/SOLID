using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.SRP
{
    public class QuinzeOuVinteCincoPorcento : TemplateRegraDeCalculo
    {
        public QuinzeOuVinteCincoPorcento(double faixaSalarial=2000, double taxaMaxima=0.85, double taxaMinima=0.75) : base(faixaSalarial, taxaMaxima, taxaMinima) {}
    }
}
