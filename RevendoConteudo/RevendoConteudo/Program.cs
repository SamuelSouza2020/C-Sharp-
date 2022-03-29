using System;

namespace RevendoConteudo
{
    class Program
    {
        static void main(String[] args)
        {
            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "Pastel";

            Console.WriteLine("Produto - {0,15}", produto);
            Console.WriteLine("Val.Compra - {0,15:c}", valorCompra);
        }
    }
}
