using SOLID_Ex.Cap2;
using SOLID_Ex.Cap3;
using SOLID_Ex.Cap4;
using SOLID_Ex.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var boletos = new List<Boleto>
            {
                new Boleto(200),new Boleto(300), new Boleto(100)
            };

            var fatura = new Cap4.Fatura("Luis", 900);
            var pdb = new ProcessadorDeBoletos();
            pdb.Processa(boletos, fatura);

            Console.WriteLine($"Status da fatura: {fatura.Pago}");
        }

        private static void InjecaoDeDependenciaEAbertoEFechado()
        {

            // OCP - Open/Closed principle
            // DIR - 
            var compra = new Compra(500, "sao paulo");
            var calc = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Transportadora());
            Console.WriteLine(calc.Calcula(compra));
        }

        private static void Acoplamento()
        {
            var listaDeAcoes = new List<IAcaoAposGerarNota>() { new EnviadorDeEmail(), new NotaFiscalDao() };
            var geradorDeNotaFiscal = new GeradorDeNotaFiscal(listaDeAcoes);
            var fatura = new Cap2.Fatura(200);
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
