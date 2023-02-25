//Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
//uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
//que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
//para ser responsável pelos cálculos.

//Qual é a cotação do dólar? 3.10
//Quantos dólares você vai comprar? 200.00
//Valor a ser pago em reais = 657.20

using System.Globalization;

namespace curso.POO
{
    public class ConversorDeMoedas
    {
        public static double Iof = 6.0;

        public static void Executar()
        {
            ProgramFake.Exibir();
        }

        public static double ConverterValorDolarEmReais(double valorCompra, double cotacao)
        {
            double total = valorCompra * cotacao;
            return total + total * Iof / 100.0;
        }
    }


    //Simulando a class program, para invocar o método estático da class ConversorDeMoedas    
    // ==> OBSERVAÇÃO:
    // Apenas criei outra classe no mesmo arquivo, pois a class program
    // já está sendo utilizada para exibir os exercícios.

    public class ProgramFake
    {
        public static void Exibir()
        {
            Console.Write("Qual o valor do Dolar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Qual o valor em dólares que deseja comprar: ");
            double valorCompraDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //utilizando método de outra classe
            double valorPagar = ConversorDeMoedas.ConverterValorDolarEmReais(cotacaoDolar, valorCompraDolar);

            Console.WriteLine("\nValor a se pagar em reais R$: " 
                + valorPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
