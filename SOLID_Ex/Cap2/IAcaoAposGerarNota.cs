using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.Cap2
{
    public interface IAcaoAposGerarNota
    {
        void Executa(NotaFiscal nf);
    }
}
