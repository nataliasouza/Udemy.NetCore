//Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números 
//com uma mensagem explicativa, conforme exemplos.

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaSequencial
{
    public class Sequencial01
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite um número: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            Console.WriteLine($"\nSOMA = {soma}");
        }
    }
}
