//Ler um número inteiro N e calcular todos os seus divisores.


namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaRepetitivaFor
{
    public class RepetitivaFor06
    {
        public static void Executar()
        {
            Console.Write("Digite um número para saber seus divisores: ");
            int numeroDigitado = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numeroDigitado; i++)
            {
                if(numeroDigitado % i == 0)
                {
                    Console.Write($"{i} ");
                }                
            }
        }
    }
}
