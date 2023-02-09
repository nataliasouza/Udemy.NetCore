//Escreva um programa que repita a leitura de uma senha até que ela seja válida.
//Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
//Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido"
//e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

//ENTRADA ------------------------------------- SAIDA
//2200    ------------------------------------- Senha Invalida
//1020    ------------------------------------- Senha Invalida
//2022    ------------------------------------- Senha Invalida
//2002    ------------------------------------- Acesso Permitido

/// <summary>
/// 
/// Observação neste exercício considerei que é necessário cadastrar uma senha
/// e não usar a senha com valor fixo! Para testar com os valores de entrada acima,
/// faça o cadastro da senha com o valor de entrada!
/// 
/// </summary>

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaRepetitiva
{
    public class Repetitiva01
    {
        public static void Executar()
        {
            string senhaDigitada, senhaCadastrada;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===========================================");
            Console.WriteLine("============ Cadastro de senha ============");
            Console.WriteLine("===========================================\n");            
            Console.ResetColor();
            Console.Write("Digite uma senha: ");           
            senhaCadastrada = Console.ReadLine();             
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("===========================================");
            Console.WriteLine("========== Autenticação de Senha ==========");
            Console.WriteLine("===========================================\n");
            Console.ResetColor();
            Console.Write("Digite sua senha: ");
            senhaDigitada = Console.ReadLine();
            Console.WriteLine("===========================================");
            Console.Clear();

            while(senhaCadastrada != senhaDigitada)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Senha inválida!");
                Console.ResetColor();
                Console.Write("\nAperte enter para digitar a senha novamente!");
                Console.ReadKey();                
                Console.Clear();

                Console.Write("\nDigite sua senha: ");
                senhaDigitada = Console.ReadLine();
                Console.Clear();
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nAcesso Pemitido!");
            Console.ResetColor();
        }

    }
}
