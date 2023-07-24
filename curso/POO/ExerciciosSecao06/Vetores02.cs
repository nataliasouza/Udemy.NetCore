//Fazer um programa para ler um número inteiro N e os dados (nome e
//preço) de N Produtos. Armazene os N produtos em um vetor. Em
//seguida, mostrar o preço médio dos produtos.

using System.Globalization;


namespace curso.POO.ExerciciosSecao06
{
    public class Vetores02
    {
        public static void Executar()
        {
            Console.Write("Digite a quantidade de produtos: ");
            int quantidadeProdutos= int.Parse(Console.ReadLine()!);

            Produto08[] produtos = new Produto08[quantidadeProdutos];
            
            for(int i = 0; i < quantidadeProdutos; i++)
            {
                Console.Write("\nDigite o nome do produto: ");
                string nome = Console.ReadLine()!;               

                Console.Write("Digite o preço: ");
                double preco = double.Parse(Console.ReadLine()!);

                produtos[i] = new Produto08 { Nome = nome, Preco = preco };
            }

            double soma = 0.0;

            for (int i = 0; i < quantidadeProdutos; i++)
            {
                soma += produtos[i].Preco;
            }

            double media = soma / quantidadeProdutos;

            Console.WriteLine("\nAVERAGE PRICE = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    public class Produto08
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
