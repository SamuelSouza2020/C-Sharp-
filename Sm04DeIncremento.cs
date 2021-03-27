using System;

namespace teste
{
    class Sm04DeIncremento
    {
        static void Main(String[] args)
        {
            //Um comando pode ser descrito de diversas maneiras
            //Operação normal
            int x = 10;
            x = x + 1;
            //Para operação atribuída
            int z = 20;
            z+= 50;
            //Os resultados serão os mesmos

            //Pré Incremento e Decremento
            int y = 10;
            //Para somar
            ++y;
            //Para subtrair
            --y;

            //Pós Incremento e Decremento
            int n = 5;
            //Para somar
            n++;
            //Para subtrair
            n--;

            //A diferença é que no pré ele faz a operação antes de finalizar a instrução
            //No pós depois de finalizar a instrução
        }
    }
}
