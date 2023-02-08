
//Fazer um programa para ler um número inteiro, e depois dizer 
//se este número é negativo ou não.

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaCondicional
{
    public class Exercicio01
    {
        public static void Executar()
        {
            Console.Write("Digite um número para saber se é negativo: ");
            int numDigitado = int.Parse(Console.ReadLine());

            if (numDigitado < 0)
            {
                Console.WriteLine("\nEste número é negativo! " +
                    "\nO número digitado foi: " +numDigitado);
            }
            else
            {
                Console.WriteLine("\nEste número é positivo! " +
                    "\nO número digitado foi: " +numDigitado);
            }
        }
    }
}
