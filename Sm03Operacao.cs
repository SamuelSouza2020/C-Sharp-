using System;

namespace teste
{
    class Sm03Operacao
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
            float notaSom = notaMax + nota;
            float notaMult = notaMax * nota;
            float notaDiv = notaMax / nota;
            //Caso use divisão em um float sendo que os dois são inteiro
            //para ver o valor flutuante é necessario colocar o F em um dos valores
            float divSem = 10 / 3; //nessa divisão será mostrado somente numero inteiro pois não tem F
            float divCom = 10 / 3f; //nessa mostrará porque tem o F em um dos valores
                
                
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
