
using System.Collections.Generic;

namespace curso.LogicaProgramacao.ExerciciosPropostos
{
    public class Exercicio05
    {
        public static double resultado = 0;
        public static int quantidadeProduto = 0; 

        public static void Executar()
        {
            ExibirMenu();
        }

        public static void ExibirMenu()
        {
            double valorProduto;
            //string nomeProduto;
            string opcao = "0";

            while (opcao != "6")
            {
                Console.WriteLine("=================================================");
                Console.WriteLine("== CÓDIGO ==== ESPECIFICAÇÃO =========== PREÇO ==");
                Console.WriteLine("=================================================\n");
                Console.WriteLine(" - 1 --------- Mini Pizza -------------- R$ 9.90");
                Console.WriteLine(" - 2 --------- X-Salada ---------------- R$ 19.90");
                Console.WriteLine(" - 3 --------- X-Bacon ----------------- R$ 21.90");
                Console.WriteLine(" - 4 --------- Refrigerante ------------ R$ 6.50");
                Console.WriteLine(" - 5 --------- Cerveja ----------------- R$ 11.00");
                Console.WriteLine(" - 6 --------- Sair do programa -----------------");
                Console.WriteLine("\n=================================================");

                Console.Write("\nDigite uma opção: ");
                opcao = Console.ReadLine();

                if (opcao != "6")
                {
                    switch (opcao)
                    {
                        case "1":
                            valorProduto = 9.90;
                            //nomeProduto = "Mini Pizza";                         
                            CalcularSoma(valorProduto);
                            Console.WriteLine($"\nValor Unitário da Mini Pizza R$:{valorProduto:F2}");
                            Console.WriteLine($"Quantidade: {quantidadeProduto}");
                            TotalValores();
                            DesejaAdicionarItens();
                            MsgAperteTecla();                            
                            break;

                        case "2":
                            valorProduto = 19.90;
                            //nomeProduto = "X-Salada";                            
                            CalcularSoma(valorProduto);
                            Console.WriteLine($"\nValor Unitário do X-Salada R$:{valorProduto:F2}");
                            Console.WriteLine($"Quantidade: {quantidadeProduto}");
                            TotalValores();
                            DesejaAdicionarItens();
                            MsgAperteTecla();                            
                            break;

                        case "3":
                            valorProduto = 21.90;
                            //nomeProduto = "X-Salada";                            
                            CalcularSoma(valorProduto);
                            Console.WriteLine($"\nValor Unitário do X-Bacon R$:{valorProduto:F2}");
                            Console.WriteLine($"Quantidade: {quantidadeProduto}");
                            TotalValores();
                            DesejaAdicionarItens();
                            MsgAperteTecla();                            
                            break;

                        case "4":
                            valorProduto = 6.50;
                            //nomeProduto = "Refrigerante 600 ML";                            
                            CalcularSoma(valorProduto);
                            Console.WriteLine($"\nValor Unitário do Refrigerante R$:{valorProduto:F2}");
                            Console.WriteLine($"Quantidade: {quantidadeProduto}");
                            TotalValores();
                            DesejaAdicionarItens();
                            MsgAperteTecla();                            
                            break;

                        case "5":
                            valorProduto = 11.00;
                            //nomeProduto = "Cerveja 600 ML";                            
                            CalcularSoma(valorProduto);
                            Console.WriteLine($"\nValor Unitário da Cerveja R$:{valorProduto:F2}");
                            Console.WriteLine($"Quantidade: {quantidadeProduto}");
                            TotalValores();                            
                            DesejaAdicionarItens();
                            MsgAperteTecla();                         
                            break;

                        default:
                            Console.WriteLine("\nDigite uma opção válida!");
                            MsgAperteTecla();
                            Console.ReadKey();
                            break;
                    }
                }
                Console.Clear();
            }
        }

        private static void MsgAperteTecla()
        {
            Console.Write("\nAperte uma tecla para continuar");
            Console.ReadKey();
        }

        private static void TotalValores()
        {            
            Console.Write("\n Total= {0:0.00} \n\n", resultado);       
            
        }
        private static void CalcularSoma(double valor)
        {
            Console.Write("Digite a quantidade do Produto: ");
            quantidadeProduto = int.Parse(Console.ReadLine());

            resultado += valor * quantidadeProduto;
        }

        private static void DesejaAdicionarItens()
        {            
            Console.WriteLine("===> S ou s para SIM ou N ou n para Não");
            Console.Write("\nDeseja adicionar mais um item: ");

            string adicionarItens = Console.ReadLine();
            
            if(adicionarItens == "S" || adicionarItens == "s")
            {
                Console.Clear();
                ExibirMenu();
            }
            else
            {
                Console.Clear();                
                Console.WriteLine("\nValor Total a pagar: " + resultado.ToString("F2"));                
                Console.WriteLine("\nObrigada por sua preferência!"); 
                Environment.Exit(0);
            }
        }
    }
}
