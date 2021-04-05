using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 palavras e utilize espaço para separar e aperte o enter para salvar");
            string[] palavras = Console.ReadLine().Split(' ');

            string palavra1 = palavras[0];
            string palavra2 = palavras[1];
            string palavra3 = palavras[2];

            Console.WriteLine("\nVOCÊ DIGITOU: \n");
            Console.WriteLine($"Primeira palavra: {palavra1}");
            Console.WriteLine($"Segunda palavra: {palavra2}");
            Console.WriteLine($"Terceira palavra: {palavra3}");
        }
    }
}
