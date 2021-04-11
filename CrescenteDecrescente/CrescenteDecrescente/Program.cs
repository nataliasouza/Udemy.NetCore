using System;

namespace CrescenteDecrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Digite dois número e os separe com espaço: ");
            string[] numeros = Console.ReadLine().Split(' ');
                        num1 = int.Parse(numeros[0]);
            num2 = int.Parse(numeros[1]);

            while (num1 != num2)
            {
                if (num1 < num2)
                {
                    Console.Write("Crescente");
                }
                else
                {
                    Console.Write("Decrescente");
                }

                Console.Write("\nDigite dois número e os separe com espaço: ");
                numeros = Console.ReadLine().Split(' ');
                num1 = int.Parse(numeros[0]);
                num2 = int.Parse(numeros[1]);
            }

        }
    }
}
