using System;

namespace teste
{
    class Program
    {
        static void Main(String[] args)
        {
            //Nesse voce declara 2 variaveis com determinado valor e usa outra
            //Para fazer a operação aritmetica
            int x = 10;
            int y = 20;

            int soma = x + y;
            int subtracao = y - x;
            int divisao = y / x;
            int multiplicacao = y * x;

            //As operações aritméticas podem ser feita diretamente na variavel
            int naVariavel = 35 + 10;
        }
    }
}