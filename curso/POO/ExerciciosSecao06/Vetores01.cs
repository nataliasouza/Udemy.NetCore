//Fazer um programa para ler um número inteiro N e a altura de N pessoas.
//Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
//pessoas.

using System.Globalization;

namespace curso.POO.ExerciciosSecao06
{
    public class Vetores01
    {
        public static void Executar()
        {
            Console.Write("Digite a quantidade de números que serão inseridos: ");
            int quantidadeDeNumeros = int.Parse(Console.ReadLine()!);

            double[] valoresInseridosDaAltura = new double[quantidadeDeNumeros];

            for (int i = 0; i < quantidadeDeNumeros; i++)
            {
                Console.Write($"Insira o {i + 1} valor da altura: ");
                valoresInseridosDaAltura[i] = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            }

            double somaDosValores = 0.0;

            for (int i = 0; i < quantidadeDeNumeros; i++)
            {
                somaDosValores += valoresInseridosDaAltura[i];
            }

            double media = somaDosValores / quantidadeDeNumeros;
            
            Console.WriteLine("\nAVERAGE HEIGHT = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
