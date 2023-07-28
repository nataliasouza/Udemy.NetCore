//A dona de um pensionato possui dez quartos para alugar para estudantes,
//sendo esses quartos identificados pelos números 0 a 9.

//Quando um estudante deseja alugar um quarto, deve-se registrar o nome
//e email deste estudante.

//Fazer um programa que inicie com todos os dez quartos vazios, e depois
//leia uma quantidade N representando o número de estudantes que vão
//alugar quartos (N pode ser de 1 a 10).
//
//Em seguida, registre o aluguel dos N estudantes. Para cada registro de aluguel,
//informar o nome e email do estudante, bem como qual dos quartos ele escolheu (de 0 a 9).
//Suponha que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
//um relatório de todas ocupações do pensionato, por ordem de quarto,
//conforme exemplo.

namespace curso.POO.ExerciciosSecao06
{
    public class Quarto
    {       
        public static void Executar()
        {
            Estudante[] quartoEstudante = new Estudante[10];
            Console.Write("Quantidade de quartos que serão alugados: ");
            int quantidadeEstudantes = int.Parse(Console.ReadLine()!);
            
            for (int i = 0; i < quantidadeEstudantes; i++)
            {
                Console.WriteLine($"\nAluguel #{i}:");

                Console.Write("\nDigite o Nome do estudante: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o E-mail do estudante: ");
                string email = Console.ReadLine();

                Console.Write("Número do Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());           

                while (numeroQuarto < 0 || numeroQuarto > 10)
                {
                    Console.Write("\n\nDigite o número do quarto (0 - 9)!: ");
                    int numeroQuartoValido = int.Parse(Console.ReadLine());

                    numeroQuarto = numeroQuartoValido;

                }

                quartoEstudante[numeroQuarto] = new Estudante(nome, email);

            }

            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (quartoEstudante[i] != null)
                {
                    Console.WriteLine(i + ": " + quartoEstudante[i]);
                }
            }
        }       
            
    }

    public class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }     

        public Estudante(string nome, string email)
        {            
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
