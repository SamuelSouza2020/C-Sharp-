using System;

namespace RevendoConteudo
{
    class Program
    {
        static void Main(String[] args)
        {
            /*O valor nao é alterado*/
            const string stConst = "Testando";
            const double dbConst = 3.321;

            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "Pastel";
            //{numero da casa, numero de espaço}
            //{0,15}
            Console.WriteLine("Produto - {0,15}", produto);
            //{numero da casa, numero de espaço: tipo monetário}
            //{0,15:c}
            Console.WriteLine("Val.Compra - {0,10:c}", valorCompra);
        }
    }
}
