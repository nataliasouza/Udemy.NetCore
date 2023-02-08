//Fazer um programa que leia três valores com ponto flutuante de dupla precisão:
//A, B e C. Em seguida, calcule e mostre:

//a) a área do triângulo retângulo que tem A por base e C por altura.
//b) a área do círculo de raio C. (pi = 3.14159)
//c) a área do trapézio que tem A e B por bases e C por altura.
//d) a área do quadrado que tem lado B.
//e) a área do retângulo que tem lados A e B.

//ENTRADA ------------------------------------- SAIDA
//3.0 4.0 5.2 --------------------------------- TRIÂNGULO: 7.800
//3.0 4.0 5.2 --------------------------------- CÍRCULO: 84.949
//3.0 4.0 5.2 --------------------------------- TRAPÉZIO: 18.200
//3.0 4.0 5.2 --------------------------------- QUADRADO: 16.000
//3.0 4.0 5.2 --------------------------------- RETÂNGULO: 12.000

using System.Globalization;

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaSequencial
{
    public class Sequencial06
    {
        public static void Executar()
        {
            double lado1, lado2, lado3, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            lado1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            lado2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            lado3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = lado1 * lado3 / 2.0;
            circulo = 3.14159 * lado3 * lado3;
            trapezio = (lado1 + lado2) / 2.0 * lado3;
            quadrado = lado2 * lado2;
            retangulo = lado1 * lado2;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
