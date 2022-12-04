//Exercício Apostila Curso Completo C#
//SPLIT - Parte 2
//Ler um número inteiro, um caractere, um número double.
// Ler um nome (única palavra), sexo(caractere F ou M), idade(inteiro) e
//altura(double) na mesma linha, armazenando-os em quatro variáveis com os devidos tipos.

using System.Globalization;

namespace curso.LogicaProgramacao
{
    public class SplitParte2
    {
        public static void Executar()
        {
            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
            Console.WriteLine("Digite na mesma linha e utilize espaço entre as informações!");
            Console.WriteLine("Depois clique em enter para visualizar.");
            Console.Write("\n\tInforme: Nome, Sexo (F ou M), Idade e Altura" +
                "\n\tExemplo: Fulana F 38 1.75 \n\n\tDigite: ");

            string[] vetDados = Console.ReadLine().Split(' ');
            string Nome = vetDados[0];
            char Sexo = char.Parse(vetDados[1]);
            int Idade = int.Parse(vetDados[2]);
            double Altura = double.Parse(vetDados[3], CultureInfo.InvariantCulture);
            Console.Write("\nClique em alguma tecla para continuar...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("=====================");
            Console.WriteLine("VOCÊ DIGITOU: ");
            Console.WriteLine("\nNome: " + Nome);
            Console.WriteLine("Sexo: " + Sexo);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Altura: " + Altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("=====================");
            Console.ReadKey();
        }
    }
}
