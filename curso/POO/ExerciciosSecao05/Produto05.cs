//Fazer um programa para ler os dados de um produto em estoque (nome, preço e
//quantidade no estoque).

//Em seguida:

//• Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque)
//• Realizar uma entrada no estoque e mostrar novamente os dados do produto
//• Realizar uma saída no estoque e mostrar novamente os dados do produto.

//Vamos criar um construtor opcional, o qual recebe apenas nome e
//preço do produto. A quantidade em estoque deste novo produto, por
//padrão, deverá então ser iniciada com o valor zero.

using System.Globalization;

namespace curso.POO.ExerciciosSecao05
{
    public class Produto05
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto05()
        {
            Quantidade = 0;
        }

        //Referenciar outro construtor em um construtor 
        public Produto05(string nome, double preco) : this() 
        {
            Nome = nome;
            Preco = preco;            ;
        }
     
        public Produto05(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }         
     
        public static void Executar()
        {

            Console.Write("Digite o nome do Produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto05 produto = new Produto05(nome, preco, quantidade);

            ExibirDadosProduto(produto);
            AdicionarOuRemoverProduto(produto);

            Console.WriteLine($"\nDADOS FINAIS: \n{produto}");
        }

        public override string ToString()
        {
            return "\nNome produto: " + Nome +
                "\nQuantidade: " + Quantidade +
                "\nPreço Unitário R$: " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                "\nValor Total: " + ValorTotalEmEstoque(Preco, Quantidade).ToString("F2", CultureInfo.InvariantCulture);
        }

        public static void ExibirDadosProduto(Produto05 produto)
        {
            Console.Clear();
            Console.WriteLine("\n=============================================");
            Console.WriteLine("== Nome ========== Quantidade == PREÇO ======");
            Console.WriteLine("=============================================\n");
            Console.WriteLine($" - Nome: {produto.Nome} " +
                $"- Quantidade: {produto.Quantidade} " +
                $"- R$ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}");

            double total = ValorTotalEmEstoque(produto.Preco, produto.Quantidade);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\t TOTAL: {total.ToString("F2", CultureInfo.InvariantCulture)} ");
            Console.ResetColor();
            Console.WriteLine("\n=============================================");
            MsgAperteTecla();
        }

        public static void AdicionarOuRemoverProduto(Produto05 produto)
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
                                AdicionarQuantidadeProduto(produto);
                                break;

                            case "2":
                                RemoverProdutos(produto);
                                break;

                            case "3":
                                ExibirDadosProduto(produto);
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
                ExibirDadosProduto(produto);
            }
        }

        public static double ValorTotalEmEstoque(double preco, int quantidade)
        {
            double valorTotal = preco * quantidade;
            return valorTotal;
        }

        public static void AdicionarQuantidadeProduto(Produto05 produto)
        {
            Console.Write($"\nDigite a quantidade do produto: {produto.Nome}, que deseja incluir: ");
            int quantidadeAtualizada = int.Parse(Console.ReadLine());

            produto.Quantidade += quantidadeAtualizada;

            ExibirDadosProduto(produto);
        }

        public static void RemoverProdutos(Produto05 produto)
        {
            Console.Write($"\nDigite a quantidade do produto: {produto.Nome}, que deseja excluir: ");
            int quantidadeAtualizada = int.Parse(Console.ReadLine());

            produto.Quantidade -= quantidadeAtualizada;

            ExibirDadosProduto(produto);
        }

        public static void MsgAperteTecla()
        {
            Console.Write("\nAperte uma tecla para continuar ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
