using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.SRP
{
    public abstract class TemplateRegraDeCalculo : IRegraDeCalculo
    {
        public double FaixaSalarial { get; protected set; }
        public double TaxaMaxima { get; protected set; }
        public double TaxaMinima { get; protected set; }

        protected TemplateRegraDeCalculo(double faixaSalarial, double taxaMaxima, double taxaMinima)
        {
            FaixaSalarial = faixaSalarial;
            TaxaMaxima = taxaMaxima;
            TaxaMinima = taxaMinima;
        }

        public double Calcula(Funcionario funcionario)
        {
            return VerificacaoFaixaSalarial(funcionario) ? funcionario.SalarioBase * TaxaMinima : funcionario.SalarioBase * TaxaMaxima;
        }

        public bool VerificacaoFaixaSalarial(Funcionario funcionario)
        {
            return funcionario.SalarioBase >= FaixaSalarial;
        }
    }
}
