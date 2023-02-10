//Digitar um número N e depois N valores inteiros.
//Mostrar a soma dos N valores digitados.

namespace curso.LogicaProgramacao
{
    public static class SomarInteiros
    {
        public static int quantidadeNumeros = 0;
        public static int valorDigitado = 0;
        public static int valorTotal = 0;

        public static void Executar()
        {
            Console.Write("Quantos números inteiros você quer digitar? \n\tDigite aqui: ");
            int quantidadeNumeros = int.Parse(Console.ReadLine());
            Console.Clear();

            for(int i = 1; i <= quantidadeNumeros; i++)
            {
                Console.Write($"Digite o {i} valor: ");
                valorDigitado = int.Parse(Console.ReadLine());
                valorTotal += valorDigitado;
            }
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;                     
            Console.Write($"Soma = {valorTotal} ");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
