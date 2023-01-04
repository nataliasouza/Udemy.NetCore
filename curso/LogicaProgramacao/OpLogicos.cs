//Exercícios Propostos - Parte 1 - Operadores Lógicos

//Procedência: ! > && > ||

namespace curso.LogicaProgramacao
{
    public class OpLogicos
    {
        public static void Executar()
        {
            bool c1 = 2 > 3 || 4 != 5;
            bool c2 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("\n----------\n");

            bool c3 = 10 < 5;
            bool c4 = c1 || c2 && c3;

            Console.WriteLine(c3);
            Console.WriteLine(c4);
        }
    }
}
