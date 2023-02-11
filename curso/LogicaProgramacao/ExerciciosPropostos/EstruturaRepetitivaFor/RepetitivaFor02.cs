//Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão
//lidos em seguida. Mostre quantos destes valores X estão dentro do intervalo [10,20] e
//quantos estão fora do intervalo, mostrando essas informações conforme exemplo
//(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaRepetitivaFor
{
    public static class RepetitivaFor02
    {
        private static int verificaValor = 1;
        private static int valorDigitado = 0;
        private static int cont_dentro = 0;
        private static int cont_fora = 0;
        public static void Executar()
        {
            Console.Write("Digite um valor inteiro: ");
            valorDigitado = int.Parse(Console.ReadLine());          

            for (int i = 1; i <= valorDigitado; i++)
            {
                if (verificaValor >= 1 && verificaValor <= 9)
                {
                    verificaValor += 1;
                    cont_fora++;
                }
                else if  (verificaValor >= 21)
                {
                    verificaValor += 1;
                    cont_fora++;                    
                }
                else 
                {
                    verificaValor += 1;
                    cont_dentro++;
                }
            }
            Console.WriteLine("\nIntervalo dos elementos [10,20]\n");
            Console.WriteLine($"\t {cont_dentro} elementos dentro do intervalo");
            Console.WriteLine($"\t {cont_fora} elementos fora do intervalo");           
        }
    }
}
