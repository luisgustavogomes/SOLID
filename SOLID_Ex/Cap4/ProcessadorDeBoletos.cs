using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.Cap4
{
    public class ProcessadorDeBoletos
    {
        public void Processa(IList<Boleto> boletos , Fatura fatura)
        {
            foreach (var boleto in boletos)
            {
                fatura.AdicionaPagamento(new Pagamento(boleto.Valor, MeioDePagamento.BOLETO));
            }
        }

    }
}
