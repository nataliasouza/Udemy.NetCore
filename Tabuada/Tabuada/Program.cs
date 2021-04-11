using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para visualizar a Tabuada: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n***** TABUADA DE MULTIPLICAÇÃO DO NÚMERO: {num} *****\n");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = num * i;
                Console.WriteLine(num + " x " + i + " = " + resultado);
            }
            Console.WriteLine("\n***** FIM DA TABUADA *****");
        }
    }
}
