using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOLID_Ex.Cap5
{
    public class ContaComum
    {
        public Double Saldo { get; private set; }

        public ContaComum()
        {
            Saldo = 0;
        }

        public virtual void Deposita(Double valor)
        {
            Saldo += valor;
        }

        /// <summary>
        /// Teste de documentação .NET
        /// </summary>
        /// <param name="valor"></param>
        public void Saca(Double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor
            } else
            {
                throw new ArgumentException("Saldo insuficiente");
            }
        }

        public virtual void SomaInvestimento()
        {
            Saldo += Saldo * 0.01;
        }


    }


}