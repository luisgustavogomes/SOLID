using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.Cap3
{
    public class Compra
    {
        public double Valor { get; private set; }
        public string Cidade { get; private set; }

        public Compra(double valor, string cidade)
        {
            Valor = valor;
            Cidade = cidade;
        }
    }
}