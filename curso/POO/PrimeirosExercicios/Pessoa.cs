//Fazer um programa para ler os dados de duas pessoas,
//depois mostrar o nome da pessoa mais velha.

namespace curso.POO.PrimeirosExercicios
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;


        public static void Executar()
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            pessoa1.Nome = Console.ReadLine();

            Console.Write("Digite a idade da primeira pessoa: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o nome da segunda pessoa: ");
            pessoa2.Nome = Console.ReadLine();

            Console.Write("Digite a idade da segunda pessoa: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"\nNome da pessoa mais experiente: {pessoa1.Nome} \n\t e tem {pessoa1.Idade} idade.");
            }

            else if(pessoa1.Idade == pessoa2.Idade)
            {
                Console.WriteLine("\nPossuem a mesma idade!!!");
                Console.WriteLine($"\nNome da pessoa: {pessoa1.Nome} \n\t e tem {pessoa1.Idade} idade.");
                Console.WriteLine($"\nNome da pessoa: {pessoa2.Nome} \n\t e tem {pessoa2.Idade} idade.");
            }

            else
            {
                Console.WriteLine($"\nNome da pessoa mais experiente: {pessoa2.Nome} \n\t e tem {pessoa2.Idade} idade.");
            }

        }
    }    
}
