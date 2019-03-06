using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.Cap3
{
    public class CalculadoraDePrecos
    {
        public ITabelaDePreco Tabela { get; private set; }
        public IServicoDeEntrega Entrega { get; private set; }

        public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoDeEntrega entrega)
        {
            Tabela = tabela;
            Entrega = entrega;
        }

        public double Calcula(Compra produto)
        {
            var desconto = Tabela.DescontoPara(produto.Valor);
            var frete = Entrega.Para(produto.Cidade);
            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
