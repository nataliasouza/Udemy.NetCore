//Fazer um programa para ler quatro valores inteiros A, B, C e D.
//A seguir, calcule e mostre a diferença do produto
//de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaSequencial
{
    public class Sequencial03
    {
        public static void Executar()
        {
            Console.WriteLine("Digite 4 valores separandos com espaço e na mesma linha");
            string[] valores = Console.ReadLine().Split(' ');

            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);
            int valor3 = int.Parse(valores[2]);
            int valor4 = int.Parse(valores[3]);

            double resultado = valor1 * valor2 - valor3 * valor4;

            Console.WriteLine("Diferença" + resultado);
        }
    }
}
