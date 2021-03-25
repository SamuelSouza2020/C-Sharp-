using System;

namespace teste
{
    class Program
    {
        static void Main(String[] args)
        {
            //Um comando pode ser descrito de diversas maneiras
            //De operação normal
            int x = 10;
            x = x + 1;
            //para operação atribuida
            int z = 50;
            z+= 50;
            //Os resultados serão os mesmos

            //Incremento e Decremento Pré
            int y = 10;
            //Para acrescentar
            ++y;
            //Para diminuir
            --y;

            //Incremento e Decremento Pós
            int n = 5;
            //Para acrescentar
            n++;
        }
    }
}