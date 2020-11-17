using System;

namespace Projeto_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int i =0;
            int num;
            int resultado;
            Console.WriteLine("Digite um número inteiro para saber sua tabuada.");
            num = int.Parse(Console.ReadLine());

            for(i=0; i<=10; i++){
                resultado = num*i;
                Console.WriteLine(+num+ "x"+i+" = "+resultado);
            }

        }
    }
}
