using System;
using System.Globalization;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite apenas 1 caracter: ");
            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número facionado: ");
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite um nome, o sexo (F = Feminino | M = Masculino), idade e altura: ");
            string[] dataUser = Console.ReadLine().Split(' ');
            
            string name = dataUser[0];
            char sex = char.Parse(dataUser[1]);
            int age = int.Parse(dataUser[2]);     
            float heigth = float.Parse(dataUser[3], (CultureInfo.InvariantCulture));

            Console.WriteLine("\n===========================================");
            Console.WriteLine("DADOS DIGITADOS:");
            Console.WriteLine("===========================================\n");
            Console.WriteLine("Número: " +num);
            Console.WriteLine("Caracter: " +ch);
            Console.WriteLine("Número Fracionado: " + num2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\n===========================================");
            Console.WriteLine("DADOS DE USUÁRIO: ");
            Console.WriteLine("===========================================\n");
            Console.WriteLine("Nome: " + name);
            Console.WriteLine("Sexo: " + sex);
            Console.WriteLine("Idade: " + age);
            Console.WriteLine("Altura:  "+ heigth.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
