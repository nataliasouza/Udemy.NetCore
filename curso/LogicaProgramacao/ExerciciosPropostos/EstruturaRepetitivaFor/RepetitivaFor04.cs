//Fazer um programa para ler um número N. Depois leia N pares de números e
//mostre a divisão do primeiro pelo segundo.Se o denominador for igual a zero,
//mostrar a mensagem "divisao impossivel".

using System.Globalization;

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaRepetitivaFor
{
    public static class RepetitivaFor04
    {
        private static double n1, n2, numeroValido, resultado;
        public static void Executar()
        {
            Console.Write("Digite a quantidade de vezes que deseja testar uma divisão: ");
            int numeroDeDivisoes = int.Parse(Console.ReadLine());           

            for (int i = 0; i < numeroDeDivisoes; i++)
            {
                Console.Write("\nDigite dois números na mesma linha e use espaço para separar: ");
                string[] numerosDaDivisao = Console.ReadLine().Split(' ');
                n1 = double.Parse(numerosDaDivisao[0]);
                n2 = double.Parse(numerosDaDivisao[1]);                

                numeroValido = n2;

                VerificaValorValido();
                Divisao(n1, n2);
                ResultadoDivisao();
            }
        }

        public static void VerificaValorValido()
        {
            while (numeroValido == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDivisao Impossível!");
                Console.ResetColor();

                Console.Write("\nEscreva outro número: ");
                numeroValido = int.Parse(Console.ReadLine());
                Console.Clear();

                if (numeroValido == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nEscreva um número Válido!");
                    Console.ResetColor();
                    Console.WriteLine("\nO valor tem que ser diferente de 0!");
                }
                else
                {
                    n2 += numeroValido;
                }
            }
        }

        public static double Divisao(double num1, double num2)
        {
            resultado = num1 / num2;
            return resultado;
        }

        public static void ResultadoDivisao()
        {
            Console.WriteLine($"\n{n1} / {n2} = {resultado.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
