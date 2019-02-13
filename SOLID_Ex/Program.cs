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
            var t = new QuinzeOuVinteCincoPorcento();
            Console.WriteLine(t.Calcula(new Funcionario(2000)));
            
        }
    }
}
