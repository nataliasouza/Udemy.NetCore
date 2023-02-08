//Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho,
//e depois mostrar os dados na tela


//***Dados em vermelho: 

//Alex Green
//3
//500.50
//Green 21 1.73


using System.Globalization;

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaSequencial
{
    public class ExercicioFixacaoSequencial
    {
        public static void Executar()
        {
            Console.Write("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa?: ");
            int quartos = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] info = Console.ReadLine().Split(' ');
            string ultimoNome = info[0];
            int idade = int.Parse(info[1]);
            double altura = double.Parse(info[2], CultureInfo.InvariantCulture);
            
            Console.Clear();
            Console.WriteLine("Nome Completo: " + nomeCompleto);
            Console.WriteLine("Quantidade de quartos na casa: " + quartos);
            Console.WriteLine("Preço: " + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Sobrenome: " + ultimoNome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
