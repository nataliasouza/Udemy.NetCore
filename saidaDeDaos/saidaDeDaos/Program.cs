using System;
using System.Globalization;

namespace saidaDeDaos
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Computador";

            byte idade = 30;
            int codigo = 5240;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("==== PRODUTOS =============================================\n");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}\n");

            Console.WriteLine("==== REGISTRO =============================================\n");
            Console.WriteLine($"{idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine("===========================================================\n");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (Três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));




        }
    }
}
