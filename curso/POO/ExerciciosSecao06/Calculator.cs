//Modificador params

//Suponha que se queira uma calculadora para calcular a soma de uma quantidade
//variável de valores.

namespace curso.POO.ExerciciosSecao06
{
    public class Calculator
    {
        public static void Executar()
        {
            int result = Calculator.Sum(30, 40, 1000, 55, 5 );
            Console.WriteLine(result);
        }
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }        
    }
}
