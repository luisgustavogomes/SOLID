using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.Cap4
{
    public class Fatura
    {
        public string  Cliente { get; private set; }
        public double Valor { get; private set; }
        private IList<Pagamento> pagamentos;
        public bool Pago { get; private set; }

        public Fatura(string cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
            pagamentos = new List<Pagamento>();
            Pago = false;
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            pagamentos.Add(pagamento);
            if (ValorTotalDosPagamentos() >= Valor)
            {
                Pago = true;
            }
        }

        private double ValorTotalDosPagamentos()
        {
            var total = 0.00;
            foreach (var item in pagamentos)
            {
                total += item.Valor;
            }
            return total;
        }
    }
}
