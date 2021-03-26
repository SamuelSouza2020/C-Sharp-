using System;

namespace teste
{
    class Sm04DeIncremento
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
            //Para subtrair
            --y;

            //Incremento e Decremento Pós
            int n = 5;
            //Para acrescentar
            n++;
            //Para subtrair
            n--;

            //A diferença é que no pré ele faz a operação antes de finalizar a instrução
            //No pós depois de finalizar a instrução
        }
    }
}
