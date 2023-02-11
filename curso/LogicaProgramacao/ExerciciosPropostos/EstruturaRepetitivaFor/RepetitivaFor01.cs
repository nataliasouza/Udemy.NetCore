//Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X,
//um valor por linha, inclusive o X, se for o caso.

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaRepetitivaFor
{
    public static class RepetitivaFor01
    {
        public static int valorDigitado = 0;
        public static void Executar()
        {
            Console.Write("Digite um valor inteiro: ");
            valorDigitado = int.Parse(Console.ReadLine());
            Console.Clear();

            for(int i = 1; i <= valorDigitado; i++)
            {
                if(i % 2 != 0)
                {
                    Console.Write($" {i} ");                    
                }                
            }
            Console.ReadKey();
        }
    }
}
