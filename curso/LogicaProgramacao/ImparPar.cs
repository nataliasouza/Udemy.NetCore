
namespace curso.LogicaProgramacao
{
    public class ImparPar
    {
        public static void Executar()
        {
            Console.Write("Entre com um número: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNúmero Par!");
                Console.ResetColor();
                Console.Write("\nClique em alguma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;                
                Console.WriteLine("\nNúmero Ímpar!");
                Console.ResetColor();
                Console.Write("\nClique em alguma tecla para continuar...");
                Console.ReadKey();                
                Console.Clear();
            }
        }
    }
}
