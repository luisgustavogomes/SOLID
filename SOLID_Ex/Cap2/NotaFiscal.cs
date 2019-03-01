using SOLID_Ex.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SOLID_Ex.Cap2
{
    public class NotaFiscal
    {
        private double valor;
        private double valorImposto;

        public NotaFiscal(double valor, double valorImposto)
        {
            this.valor = valor;
            this.valorImposto = valorImposto;
        }
    }
}