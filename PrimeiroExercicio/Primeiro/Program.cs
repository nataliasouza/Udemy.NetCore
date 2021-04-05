using System;
using System.Globalization;

namespace PrimeiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //Placeholders
            Console.WriteLine("{0} tem {1} anos e possui o saldo de: {2:F2}", nome, idade, saldo);

            //Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e possio o saldo de: " + saldo.ToString("F2", CultureInfo.InvariantCulture));

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e possui o saldo de: {saldo:F2}");
        }
    }
}
