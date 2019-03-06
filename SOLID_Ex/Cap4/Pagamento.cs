using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.Cap4
{
    public class Pagamento
    {
        public double Valor { get; private set; }
        public MeioDePagamento MeioDePagamento { get; private set; }

        public Pagamento(double valor, MeioDePagamento meioDePagamento)
        {
            Valor = valor;
            MeioDePagamento = meioDePagamento;
        }
    }
}
