//Ler um valor N. Calcular e escrever seu respectivo fatorial.
//Fatorial de N = N * (N-1) *(N - 2) * (N - 3) * ... *1.
//Lembrando que, por definição, fatorial de 0 é 1.

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaRepetitivaFor
{
    public class RepetitivaFor05
    {
        public static void Executar()
        {
            Console.Write("Digite um número para calcular seu fatorial: ");
            int numeroDigitado = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= numeroDigitado; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
