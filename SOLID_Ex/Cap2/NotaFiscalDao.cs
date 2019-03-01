
using SOLID_Ex.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOLID_Ex.Cap2
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Persistendo nota");
        }
    }
}