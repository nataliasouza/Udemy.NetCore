using System;
using System.Globalization;

namespace ExercicioAreaTerreno
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler as medidas da largura e comprimento de um terreno
             * retangular com uma casa decimal, bem como o valor do metro quadrado do terreno 
             * com duas casas decimais. Em seguida, o programa deve mostrar o valor da área do 
             * terreno, bem como o valor do preço do terreno, ambos com duas casas decimais.
             * Exemplo : Entrada:     SAÍDA:
             *             10.0        Area: 300.00
             *             30.0        Preco = 60000.00
             *             200.00       
             * 
             * area = largura x comprimento
             * preco = area x preco do metro quadrado
             */
            double largura, comprimento, area, valorMetroQuadrado, preco;

            Console.WriteLine("Digite a largura: ");
            largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.WriteLine("Digite o comprimento: ");
            comprimento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor do metro quadrado do terreno: ");
            valorMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * valorMetroQuadrado;

            Console.WriteLine("A área de um quadrado: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O preço do Terreno: " + preco.ToString("F2" , CultureInfo.InvariantCulture));
        }
    }
}

