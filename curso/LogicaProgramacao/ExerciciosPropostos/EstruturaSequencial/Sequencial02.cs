using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área
//deste círculo com quatro casas decimais conforme exemplos.

//Fórmula da área: area = π.raio2
//Considere o valor de π = 3.14159

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaSequencial
{
    public class Sequencial02
    {
        public static void Executar()
        {
            const double pi = 3.14159;

            Console.Write("Digite o valor do raio de um círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * raio * raio;

            Console.WriteLine("\n Valor da área = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
