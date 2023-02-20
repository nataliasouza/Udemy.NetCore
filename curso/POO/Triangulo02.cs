//Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas
//válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual
//dos dois triângulos possui a maior área. A fórmula para calcular a área de um
//triângulo a partir das medidas de seus lados a, b e c é a seguinte(fórmula de Heron):

//Problema Exemplo - COM Orientação a Objeto.
//Criando um método para obtermos os 
//benefícios de reaproveitamento e delegação.

using System.Globalization;

namespace curso.POO
{
    public class Triangulo02
    {
        public double A;
        public double B;
        public double C;

        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public static void Executar()
        {
            Triangulo02 x, y;

            x = new Triangulo02();
            y = new Triangulo02();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }        
    }
}

