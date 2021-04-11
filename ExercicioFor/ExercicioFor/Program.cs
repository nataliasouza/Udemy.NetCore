using System;

namespace ExercícioFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros inteiros você irá digitar?");
            int num = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= num; i++)
            {
                Console.Write("\nValor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());

                soma += valor;
            }
            Console.Write("\nA soma é: " + soma);
        }
    }
}
