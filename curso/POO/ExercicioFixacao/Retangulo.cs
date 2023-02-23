//Fazer um programa para ler os valores da largura e altura
//de um retângulo. Em seguida, mostrar na tela o valor de
//sua área, perímetro e diagonal. Usar uma classe como
//mostrado no projeto ao lado.

using System.Globalization;

namespace curso.POO.ExercicioFixacao
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;
        public double Perimetro;        

        public static void Executar()
        {
            Retangulo retangulo = new Retangulo();

            Console.Write("Entre com o valor da largura do retângulo: ");     
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o valor da altura do retângulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine("\n\tÁREA = " + retangulo.CalcularArea().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\tPERÍMETRO = " + retangulo.CalcularPerimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\tDIAGONAL = " + retangulo.CalcularDiagonal().ToString("F2", CultureInfo.InvariantCulture));
            Console.ResetColor();
        }

        public double CalcularArea()
        {
            return Largura * Altura;            
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largura * Altura);
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
