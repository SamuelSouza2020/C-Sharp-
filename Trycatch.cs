using System;

namespace Testetry
{
    class Program
    {
        static void Main(String[] args)
        {
            int a = 5;
            int b = 0;
            //Tratamento de excessão
            try
            {
                double c = a / b;
                Console.WriteLine(c);
            }
            catch { Console.WriteLine("Erro"); }

            Console.ReadKey();
        }
    }
}
