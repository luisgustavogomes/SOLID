using SOLID_Ex.Cap2;
using SOLID_Ex.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeAcoes = new List<IAcaoAposGerarNota>() { new EnviadorDeEmail(), new NotaFiscalDao() };
            var geradorDeNotaFiscal = new GeradorDeNotaFiscal(listaDeAcoes);
            var fatura = new Fatura(200);
            var nf = geradorDeNotaFiscal.Gera(fatura);

        }

        private static void SRP()
        {
            var calc = new CalculadoraDeSalario();
            var func = new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 2000);
            Console.WriteLine(func.CalculaSalario());
        }
    }
}
