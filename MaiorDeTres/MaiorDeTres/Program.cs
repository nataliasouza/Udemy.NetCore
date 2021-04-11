using System;

namespace MaiorDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números para saber qual é o maior");
            Console.WriteLine("Digite o 1º número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3º número: ");
            int n3 = int.Parse(Console.ReadLine());

            double resultado = MaiorDeTres(n1, n2, n3);

            Console.WriteLine("O maior entre os 3 números digitados: " + resultado);
        }

        static int MaiorDeTres(int num1, int num2, int num3)
        {
            int res;

            if(num1 > num2 && num1 > num3)
            {
                res = num1;
            }
            else if (num2 > num3)
            {
                res = num2;
            }
            else
            {
                res = num3;
            }
            return res;
        }
    }
}
