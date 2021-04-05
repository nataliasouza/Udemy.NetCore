using System;
using System.Globalization;

namespace ExercicioEntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o seu nome: ");
            string name = Console.ReadLine();

            Console.Write("\nQuantos quartos tem na sua casa? ");
            int numBedrooms = int.Parse(Console.ReadLine());

            Console.Write("\nEntre com o preço de um produto: ");
            double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre com seu último nome, idade e altura (mesma linha)");
            string[] dataUser = Console.ReadLine().Split(' ');
            string lastName = dataUser[0];
            int age = int.Parse(dataUser[1]);
            float heigth = float.Parse(dataUser[2], CultureInfo.InvariantCulture);

            Console.WriteLine("\n*************************");
            Console.WriteLine("DADOS DO USUÁRIO:");
            Console.WriteLine("*************************\n");
            Console.WriteLine("NOME: " + name);
            Console.WriteLine("QUANTIDADE DE QUARTOS: " + numBedrooms);
            Console.WriteLine("PREÇO DO PRODUTO: " + priceProduct.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("ÚLTIMO NOME: " + lastName);
            Console.WriteLine("IDADE: " + age);
            Console.WriteLine("ALTURA: " + heigth.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
