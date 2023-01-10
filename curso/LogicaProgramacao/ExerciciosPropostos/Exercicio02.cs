
//Leia dois valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "São multiplos"
//ou "Não são multiplos", indicando se os valores lidos são multiplos entre si.
//ATENÇÃO: os números devem poder ser digitados em ordem crescente ou decrescente.

namespace curso.LogicaProgramacao.ExerciciosPropostos
{
    public class Exercicio02
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o valor de A e B: ");
            string letras = Console.ReadLine();

            string[] multiplos = letras.Split(' ');
            int a = int.Parse(multiplos[0]);
            int b = int.Parse(multiplos[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São multiplos!");
            }
            else
            {
                Console.WriteLine("Não são multiplos!");
            }
        }
    }   
}
