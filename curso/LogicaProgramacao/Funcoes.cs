//Um programa para ler 3 números inteiros e mostrar na tela o maior deles.

namespace curso.LogicaProgramacao
{
    public class Funcoes
    {
        public static void Executar()
        {
            Console.Write("Digite na mesma linha com espaços, 3 números inteiros: ");
            string[] vetNumeros = Console.ReadLine().Split(' ');
            int num1 = int.Parse(vetNumeros[0]);
            int num2 = int.Parse(vetNumeros[1]);
            int num3 = int.Parse(vetNumeros[2]);

            int resultado = MaiorNumero(num1, num2, num3);
            Console.WriteLine("O maior número é: " + resultado);
            Console.ReadKey();         
        }

        public static int MaiorNumero(int n1, int n2, int n3)
        {
            int valor;

            if (n1 > n2 && n1 > n3)
            {
                valor = n1;                
            }

            else if (n2 > n1 && n2 > n3)
            {
                valor = n2;                
            }
            else
            {
                valor = n3;                                
            }
            return valor;
        }
    }
}
