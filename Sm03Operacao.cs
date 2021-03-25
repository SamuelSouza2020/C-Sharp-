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
            int naVariavel2 = 35 - 10;

            //por float
            float nota = 8.5f;
            float notaMax = 10f;

            float faltaNot = notaMax - nota;
            float notaDiv = notaMax / nota;
            float notaSom = notaMax + nota;
            float notaMult = notaMax * nota;
            //ou
            float conta = 300.5f - 223.45f;

            //para visualizar utiliza o nome dentro do console
            Console.WriteLine(conta);
            //não é necessário converter para string, mas caso queira...
            Console.WriteLine(conta.ToString());


            Console.ReadLine();
        }
    }
}