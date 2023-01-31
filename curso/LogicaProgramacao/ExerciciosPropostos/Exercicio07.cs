//Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano.
//A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou
//na origem (x= y=0). Se o ponto estiver na origem, escreva a mensagem "Origem".
//Se o ponto estiver sobre um dos eixos escreva "Eixo X" ou "Eixo Y", conforme for a situação.

using System.Globalization;

namespace curso.LogicaProgramacao.ExerciciosPropostos
{
    public class Exercicio07
    {
        public static void Executar()
        {
            Console.WriteLine("Digite 2 valores com casa decimal, Ex: 1.6 -1.9");
            Console.Write("Valores para X e Y: ");
            string[] numeros = Console.ReadLine().Split(' ');
            double x = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            double y = double.Parse(numeros[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("\nOrigem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("\nEixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("\nEixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("\nQ1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("\nQ2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("\nQ3");
            }
            else
            {
                Console.WriteLine("\nQ4");
            }

        }
    }
}
