//Expressão condicional ternária

//Estrutura opcional ao if-else quando se deseja decidir um VALOR com base em uma
//condição.

//Sintaxe:
//(condição) ? valor_se_verdadeiro : valor_se_falso

using System.Globalization;

namespace curso.POO.ExerciciosSecao07
{
    internal class CondicionalTernaria
    {
        public static void Executar()
        {
            //double preco = 34.5;
            //double desconto;

            //if (preco < 20.0)
            //{
            //    desconto = preco * 0.1;
            //}
            //else
            //{
            //    desconto = preco * 0.05;
            //}

            Console.WriteLine("Se preço for menor que 20, desconto é 10%, se maior é 5%");
            Console.Write("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            double total = preco - desconto;
            
            Console.WriteLine($"\n\nPreço sem desconto: {preco.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"\nDesconto: {desconto.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"\nTotal: {total.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}
