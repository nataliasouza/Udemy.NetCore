//Modificador params

//Suponha que se queira uma calculadora para calcular a soma de uma quantidade
//variável de valores.

//Modificador ref 

//Suponha que se queira uma calculadora com uma operação para triplicar o valor de
//um número passado como parâmetro.

//Modificador out

//O modificador out é similar ao ref (faz o parâmetro ser uma referência para a variável
//original), mas não exige que a variável original seja iniciada.

namespace curso.POO.ExerciciosSecao06
{
    public class Calculator
    {
        public static void Executar()
        {
            int result = Calculator.Sum(30, 40, 1000, 55, 5 );
            Console.WriteLine(result);

            int a = 10; // precisa ser iniciada
            Calculator.Triple(ref a); //Modificador ref 
            Console.WriteLine(a);

            int b = 30;
            int triple; // Não precisa ser iniciada
            Calculator.Triple(b, out triple);//Modificador out
            Console.WriteLine(triple);
        }
        public static int Sum(params int[] numbers) //Modificador params
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        
        public static void Triple(ref int x) //Modificador ref 
        {
            x = x * 3;
        }

        public static void Triple(int origin, out int result) //Modificador out
        {
            result = origin * 3;
        }
    }
}
