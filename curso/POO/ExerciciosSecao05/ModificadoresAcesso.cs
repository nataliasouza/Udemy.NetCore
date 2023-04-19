//Modificadores de Acesso - Aula 58

namespace curso.POO.ExerciciosSecao05
{
    public class ModificadoresAcesso
    {
        public static void Executar()
        {
            Console.WriteLine("ACESSO POR QUALQUER CLASSE:");
            Console.WriteLine(" \n\tpublic class Product");

            Console.WriteLine("\n\nACESSO SOMENTE DENTRO DO ASSEMBLY:");
            Console.WriteLine(" \n\tinternal class Product");
            Console.WriteLine(" \n\tclass Product");

            Console.WriteLine("\n\nACESSO SOMENTE PELA CLASSE MÃE:");
            Console.WriteLine(" \n\tprivate class Product");
            Console.WriteLine(" \n\tNota: classe aninhada, por padrão, é private");


            Console.WriteLine("\n\n=======================================================================================================================================================");
            Console.WriteLine("\n====================== própria classe === subclasses no assembly === classes do assembly ===  subclasses fora do assembly === classes fora do assembly");
            Console.WriteLine(" \n public               |       x        |              x           |          x            |                x               |            x             |");
            Console.WriteLine(" protected internal   |       x        |              x           |          x            |                x               |                          |");
            Console.WriteLine(" internal             |       x        |              x           |          x            |                                |                          |");
            Console.WriteLine(" protected            |       x        |              x           |                       |                x               |                          |");
            Console.WriteLine(" private protected    |       x        |              x           |                       |                                |                          |");
            Console.WriteLine(" private              |       x        |                          |                       |                                |                          |");
            Console.WriteLine("\n=======================================================================================================================================================\n");
        }
    }
}
