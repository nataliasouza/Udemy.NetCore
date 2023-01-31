//Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo
//em qual dos seguintes intervalos ([0,25], [25,50], [50,75], [75,100]) este valor se encontra.
//Obviamente se o valor não estiver em nenhum destes intervalos,
//deverá ser impressa a mensagem "Fora de intervalo"

using System.Globalization;

namespace curso.LogicaProgramacao.ExerciciosPropostos
{
    public class Exercicio06
    {
        public static void Executar()
        {
            double intervalo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (intervalo < 0.0 || intervalo > 100.0)
            {
                Console.WriteLine("Fora de intervalo!");
            }

            else if (intervalo <= 25.0)
            {
                Console.WriteLine("Intervalo entre [0,25]");
            }

            else if (intervalo <= 50.0)
            {
                Console.WriteLine("Intervalo entre (25,50]");
            }

            else if (intervalo <= 75.0)
            {
                Console.WriteLine("Intervalo entre (50,75]");
            }

            else
            {
                Console.WriteLine("Intervalo entre (75,100]");
            }

        } 
    }
}
