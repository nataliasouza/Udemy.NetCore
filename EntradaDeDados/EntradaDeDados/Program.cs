using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase e aperte enter quando terminar: ");
            string pharse = Console.ReadLine();

            Console.WriteLine("\nDigite uma fruta: ");
            string fruit1 = Console.ReadLine();

            Console.WriteLine("\nDigite mais uma fruta: ");
            string fruit2 = Console.ReadLine();

            Console.WriteLine("\nDigite a última fruta: ");
            string fruit3 = Console.ReadLine();

            Console.WriteLine("\nVocê digitou essa frase: ");
            Console.WriteLine(pharse);

            Console.WriteLine("\nAs frutas que você digitou foram: ");
            Console.WriteLine($"Primeira fruta:  {fruit1}");
            Console.WriteLine($"Segunda fruta:  {fruit2}");
            Console.WriteLine($"Terceira fruta: {fruit3}");

            Console.WriteLine($"\nAs frutas que foram digitadas: {fruit1}, {fruit2}, {fruit3}");

        }
    }
}
