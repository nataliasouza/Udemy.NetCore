//Fazer um programa para ler o código de uma peça 1, o número de peças 1,
//o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2
//e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

using System.Globalization;

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaSequencial
{
    public class Sequencial05
    {
        public static void Executar()
        {
            Console.Write("Digite o código, número de peças e o valor unitário: ");
            string[] valores = Console.ReadLine().Split(' ');

            int cod1 = int.Parse(valores[0]);
            int qte1 = int.Parse(valores[1]);
            double preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double totalPecas1 = preco1 * qte1;

            Console.Write("Digite o código, número de peças e o valor unitário: ");
            valores = Console.ReadLine().Split(' ');
            double cod2 = int.Parse(valores[0]);
            double qte2 = int.Parse(valores[1]);
            double preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double totalPecas2 = preco2 * qte2;

            double total = preco1 * qte1 + preco2 * qte2;

            Console.Clear();
            Console.WriteLine("\n============= Resumo do Pedido =============");
            Console.WriteLine($"\nCódigo Peça 1: { cod1} " +
                              $"\nQuantidade: {qte1} " +
                              $"\nValor: {preco1.ToString("F2", CultureInfo.InvariantCulture)} " +
                              $"\nTotal Peças 1: {totalPecas1.ToString("F2", CultureInfo.InvariantCulture)}");
           
            Console.WriteLine($"\nCódigo Peça 2: { cod2}" +
                              $"\nQuantidade: {qte2} " +
                              $"\nValor: {preco2.ToString("F2", CultureInfo.InvariantCulture)} " +
                              $"\nTotal Peças 2: {totalPecas2.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\tVALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ResetColor();
            Console.WriteLine("\n============================================");
        }
    }
}
