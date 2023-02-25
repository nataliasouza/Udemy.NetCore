//Fazer um programa para ler os dados de um produto em estoque (nome, preço e
//quantidade no estoque).

//Em seguida:

//• Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque)
//• Realizar uma entrada no estoque e mostrar novamente os dados do produto
//• Realizar uma saída no estoque e mostrar novamente os dados do produto.

//Vamos criar um construtor opcional, o qual recebe apenas nome e
//preço do produto. A quantidade em estoque deste novo produto, por
//padrão, deverá então ser iniciada com o valor zero.

// ==> Sintaxe alternativa para inicializar valores

using System.Globalization;

namespace curso.POO.ExerciciosSecao05
{
    public class Produto04
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor Padrão
        public Produto04()
        {

        }

        //Construtor Opcional com 3 argumentos
        public Produto04(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Construtor Opcional com 2 argumentos 
        public Produto04(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public static void Executar()
        {
            //Alternativas de sintaxe para inicializar valores

            //Alternativa 1
            Console.Write("Digite o nome do Produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto04 produto01 = new Produto04(nome, preco, quantidade);

            //Alternativa 2 
            Produto04 produto02 = new Produto04("uva", 15.50);

            //Alternativa 3
            Produto04 produto03 = new Produto04
            {
                Nome = "Morango",
                Preco = 25.00,
                Quantidade = 20
            };

            //Alternativa 4
            Produto04 produto04 = new Produto04()
            {
                Nome = "Morango",
                Preco = 25.00,
                Quantidade = 20
            };

            ExibirDadosProduto(produto01);
            AdicionarOuRemoverProduto(produto01);

            Console.WriteLine($"\nDADOS FINAIS: \n{produto01}");
        }

        public override string ToString()
        {
            return "\nNome produto: " + Nome +
                "\nQuantidade: " + Quantidade +
                "\nPreço Unitário R$: " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                "\nValor Total: " + ValorTotalEmEstoque(Preco, Quantidade).ToString("F2", CultureInfo.InvariantCulture);
        }

        public static void ExibirDadosProduto(Produto04 produto01)
        {
            Console.Clear();
            Console.WriteLine("\n=============================================");
            Console.WriteLine("== Nome ========== Quantidade == PREÇO ======");
            Console.WriteLine("=============================================\n");
            Console.WriteLine($" - Nome: {produto01.Nome} " +
                $"- Quantidade: {produto01.Quantidade} " +
                $"- R$ {produto01.Preco.ToString("F2", CultureInfo.InvariantCulture)}");

            double total = ValorTotalEmEstoque(produto01.Preco, produto01.Quantidade);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\t TOTAL: {total.ToString("F2", CultureInfo.InvariantCulture)} ");
            Console.ResetColor();
            Console.WriteLine("\n=============================================");
            MsgAperteTecla();
        }

        public static void AdicionarOuRemoverProduto(Produto04 produto01)
        {
            Console.Write("\nDeseja adicionar ou remover mais unidades do produto: " +
             "\n\t s para Sim ou n para não: ");
            char opcao = char.Parse(Console.ReadLine());
            Console.Clear();

            while (opcao != 's' && opcao != 'n')
            {
                Console.WriteLine("Escreva S para Sim ou N para não: ");
                opcao = char.Parse(Console.ReadLine());
            }

            if (opcao == 's')
            {
                string op = "0";

                while (op != "4")
                {
                    Console.WriteLine("\nEscolha uma opcão: \n");
                    Console.WriteLine("1 - Adicionar");
                    Console.WriteLine("2 - Remover");
                    Console.WriteLine("3 - Mostrar o valor total");
                    Console.WriteLine("4 - Sair");
                    Console.Write("\nDigite apenas o número da sua opção: ");
                    op = Console.ReadLine();

                    if (op != "4")
                    {
                        switch (op)
                        {
                            case "1":
                                AdicionarQuantidadeProduto(produto01);
                                break;

                            case "2":
                                RemoverProdutos(produto01);
                                break;

                            case "3":
                                ExibirDadosProduto(produto01);
                                break;

                            default:
                                Console.WriteLine("\nDigite uma opção válida!");
                                Console.ReadKey();
                                break;
                        }
                    }
                    Console.Clear();
                }
            }
            else
            {
                ExibirDadosProduto(produto01);
            }
        }

        public static double ValorTotalEmEstoque(double preco, int quantidade)
        {
            double valorTotal = preco * quantidade;
            return valorTotal;
        }

        public static void AdicionarQuantidadeProduto(Produto04 produto01)
        {
            Console.Write($"\nDigite a quantidade do produto: {produto01.Nome}, que deseja incluir: ");
            int quantidadeAtualizada = int.Parse(Console.ReadLine());

            produto01.Quantidade += quantidadeAtualizada;

            ExibirDadosProduto(produto01);
        }

        public static void RemoverProdutos(Produto04 produto01)
        {
            Console.Write($"\nDigite a quantidade do produto: {produto01.Nome}, que deseja excluir: ");
            int quantidadeAtualizada = int.Parse(Console.ReadLine());

            produto01.Quantidade -= quantidadeAtualizada;

            ExibirDadosProduto(produto01);
        }

        public static void MsgAperteTecla()
        {
            Console.Write("\nAperte uma tecla para continuar ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}