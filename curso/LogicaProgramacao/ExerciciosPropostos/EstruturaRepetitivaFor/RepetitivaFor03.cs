//Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. 
//Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.
//Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o
//primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

using System.Globalization;

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaRepetitivaFor
{
    public static class RepetitivaFor03
    {
        public static int numeros;
        public static double a, b, c, media;
        public static string nomeAluno;
        
        public static void Executar()
        {
            Console.Write("Digite a quantidade de alunos: ");
            numeros = int.Parse(Console.ReadLine());
            
            Console.Clear();

            for (int i = 0; i < numeros; i++)
            {
                Console.Write("\nDigite o Nome do Aluno(a): ");
                nomeAluno = Console.ReadLine();

                Console.WriteLine("\nDigite as 3 notas separadas por espaço e na mesma linha: ");
                string[] notas = Console.ReadLine().Split(' ');
                a = double.Parse(notas[0], CultureInfo.InvariantCulture);
                b = double.Parse(notas[1], CultureInfo.InvariantCulture);
                c = double.Parse(notas[2], CultureInfo.InvariantCulture);

                media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                if(media >= 6)
                {
                    ExibirMedia();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Aluno Aprovado! \n");
                    Console.ResetColor();
                }
                else
                {
                    ExibirMedia();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Aluno Reprovado! \n");
                    Console.ResetColor();
                }               
            }                
        }

        public static void ExibirMedia()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"\n {nomeAluno}, \t média: " +
                $"{media.ToString("F1", CultureInfo.InvariantCulture)} ");

            Console.ResetColor();
        }
    }
}
