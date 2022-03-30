using System;

namespace RevendoConteudo
{
    class Program
    {
        enum Luta { Espada, Escudo, Lança, Arco};
        static void Main(String[] args)
        {
            /*O valor nao é alterado*/
            const string stConst = "Testando";
            const double dbConst = 3.321;
            int testBitwich = 20;

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

            testBitwich = testBitwich << 2;

            Console.WriteLine(testBitwich);

            int tipoLuta = (int)Luta.Escudo;
            Console.WriteLine(tipoLuta);

            Luta lt = Luta.Lança;
            Console.WriteLine(lt);
        }
    }
}
