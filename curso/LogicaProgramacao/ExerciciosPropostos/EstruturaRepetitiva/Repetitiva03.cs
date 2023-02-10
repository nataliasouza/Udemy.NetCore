//Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência
//de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido
//(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim).
//Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado
//um novo código (até que seja válido). O programa será encerrado quando o código informado
//for o número 4. Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes
//que abasteceram cada tipo de combustível, conforme exemplo.

//ENTRADA ------------------------------------- SAIDA
//  8     ------------------------------------- MUITO OBRIGADO
//  1     ------------------------------------- Alcool: 1
//  7     ------------------------------------- Gasolina: 2
//  2     ------------------------------------- Diesel: 0
//  2     ------------------------------------- 
//  4     ------------------------------------- 

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaRepetitiva
{
    public static class Repetitiva03
    {
        public static int quantidadeAlcool = 0;
        public static int quantidadeGasolina = 0;
        public static int quantidadeDiesel = 0;
        public static string opcao = "0";

        public static void Executar()
        {
            ExibirMenu();
            ExibirResultadoPesquisa();
        }       

        public static void ExibirMenu()
        {                      
            while (opcao != "4")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("=================================================");
                Console.WriteLine("============ Pesquisa de Preferência ============");
                Console.WriteLine("=================================================");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("                                                 ");
                Console.WriteLine(" - 1 --- ÁLCOOL ---------------------------------");
                Console.WriteLine(" - 2 --- GASOLINA -------------------------------");
                Console.WriteLine(" - 3 --- DIESEL ---------------------------------");
                Console.WriteLine(" - 4 --- Sair do programa -----------------------");
                Console.WriteLine("                                                 ");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("=================================================");
                Console.ResetColor();


                Console.Write("\nQual foi o combustível abastecido? " +
                    "\n\tDigite sua opção: ");

                opcao = Console.ReadLine();
                OpcaoEscolhida();
                Console.Clear();                       
            }
        }

        private static void MsgAperteTecla()
        {
            Console.Write("\nAperte uma tecla para continuar");
            Console.ReadKey();
        }        

        private static void OpcaoEscolhida()
        {
            if (opcao != "4")
            {
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\nEscolheu a opção Álcool");
                        quantidadeAlcool += 1;
                        MsgAperteTecla();
                        break;

                    case "2":
                        Console.WriteLine("\nEscolheu a opção Gasolina");
                        quantidadeGasolina += 1;
                        MsgAperteTecla();
                        break;

                    case "3":
                        Console.WriteLine("\nEscolheu a opção Diesel");
                        quantidadeDiesel += 1;
                        MsgAperteTecla();
                        break;

                    default:
                        Console.WriteLine("\nDigite uma opção válida!");
                        MsgAperteTecla();
                        break;
                }
            }
        }

        private static void ExibirResultadoPesquisa()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=================================================");
            Console.WriteLine("===== Resultado da Pesquisa de Preferência ======");
            Console.WriteLine("=================================================");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                 ");
            Console.WriteLine($" - ÁLCOOL ---------------------------------- : {quantidadeAlcool} ");
            Console.WriteLine($" - GASOLINA -------------------------------- : {quantidadeGasolina} ");
            Console.WriteLine($" - DIESEL ---------------------------------- : {quantidadeDiesel} ");
            Console.WriteLine("                                                 ");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=================================================");
            Console.ResetColor();

            Console.WriteLine("\nAgradecemos sua preferência! Muito Obrigado!");
        }
    }
}
