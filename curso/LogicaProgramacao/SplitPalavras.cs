//SPLIT - Ler um texto até a quebra de linha e armazenar em uma variável.

namespace curso.LogicaProgramacao
{
    public class SplitPalavras
    {
        public static void Executar()
        {
            Console.Write("Digite 3 palavras e utilize espaço entre as palavras... \nDepois clique em enter para prosseguir!" +
                "\n\n\tDigite as palavras:  ");
            string palavras = Console.ReadLine();

            string[] vetorPalavras = palavras.Split(' ');
            string palavra1 = vetorPalavras[0];
            string palavra2 = vetorPalavras[1];
            string palavra3 = vetorPalavras[2];

            Console.WriteLine("\n3 palavras digitadas: \n", palavras);
            Console.WriteLine(palavra1);
            Console.WriteLine(palavra2);
            Console.WriteLine(palavra3);
        }
    }
}
