//Digitar um número e mostrar sua raiz quadrada com 3 casas decimais,
//depois repetir o procedimento. Quando o usuário digitar um número negativo
//(podendo ser da primeira vez), mostrar uma mensagem "Número negativo" e terminar o programa.

using System.Globalization;

namespace curso.LogicaProgramacao
{
    public class RaizQuadrada
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(numero >= 0.0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

                Console.Write("Digite outro número: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número Negativo");
        }
    }
}
