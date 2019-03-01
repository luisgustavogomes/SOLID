using SOLID_Ex.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.Cap2
{
    public class GeradorDeNotaFiscal
    {
        private IList<IAcaoAposGerarNota> acoes;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes)
        {
            this.acoes = acoes;
        }

        public NotaFiscal Gera(Fatura fatura)
        {
            var nf = new NotaFiscal(fatura.ValorMensal, ImpostoSimplesSobre(fatura.ValorMensal));
            foreach (var item in acoes)
            {
                item.Executa(nf);
            }

            return nf;

        }

        private double ImpostoSimplesSobre(double valor)
        {
            return valor * 0.06;
        }
    }
}
