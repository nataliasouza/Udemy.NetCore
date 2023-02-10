//Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos
//no sistema cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo
//será encerrado quando pelo menos uma de duas coordenadas
//for NULA (nesta situação sem escrever mensagem alguma).

//ENTRADA ------------------------------------- SAIDA
//2 2     ------------------------------------- primeiro quadrante
//3 -2    ------------------------------------- quarto quadrante
//-8 -1   ------------------------------------- terceiro quadrante
//-7 1    ------------------------------------- segundo quadrante
//7 9     ------------------------------------- outro quadrante
//0 2     ------------------------------------- o programa será fechado

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaRepetitiva
{
    public class Repetitiva02
    {
        public static void Executar()
        {
            Console.WriteLine("Digite 2 valores com casa decimal, Ex: -8 -1");
            Console.Write("Valores para X e Y: ");
            string[] numeros = Console.ReadLine().Split(' ');
            int x = int.Parse(numeros[0]);
            int y = int.Parse(numeros[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && x <= 2 && y > 0 && y <= 2)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Primeiro Quadrante \n");

                }
                else if (x < 0 && x <= -7 && y > 0 && y <= 1)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Segundo Quadrante \n");
                }
                else if (x < 0 && x <= -8 && y < 0 && y <= -1)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" \n Terceiro Quadrante \n");
                }
                else if (x > 0 && x <= 3 && y < 0 && y <= -2)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Quarto Quadrante \n");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Outro Quadrante \n");
                }

                Console.ResetColor();                
                Console.Write("Aperte enter para digitar outros valores! ");
                Console.ReadKey();
                Console.Clear();                
                Console.Write("\nValores para X e Y: ");
                numeros = Console.ReadLine().Split(' ');
                x = int.Parse(numeros[0]);
                y = int.Parse(numeros[1]);
            }
        }
    }
}
