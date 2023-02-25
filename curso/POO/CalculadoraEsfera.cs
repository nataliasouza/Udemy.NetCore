//Fazer um programa para ler um valor numérico qualquer, e daí mostrar
//quanto seria o valor de uma circunferência e do volume de uma esfera
//para um raio daquele valor. Informar também o valor de PI com duas
//casas decimais.

//Exemplo:
//Entre o valor do raio: 3.0
//Circunferência: 18.84
//Volume: 113.04
//Valor de PI: 3.14

//• Versão 1: métodos na própria classe do programa
//• Nota: dentro de um método estático você não pode chamar membros de
//instância da mesma classe.

using System.Globalization;

namespace curso.POO
{
    public class CalculadoraEsfera
    {
        static double Pi = 3.14;

        public static void Executar()
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circunferencia = CalcularCircunferencia(raio);
            double volume = CalcularVolume(raio);

            Console.Clear();

            Console.WriteLine($"\nValor do raio: {raio.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circunferência: { circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static double CalcularCircunferencia(double valorRaio)
        {
            return 2.0 * Pi * valorRaio;
        }

        static double CalcularVolume(double valorRaio)
        {
            return 4.0 / 3.0 * Pi * valorRaio * valorRaio * valorRaio;
        }
    }
}
