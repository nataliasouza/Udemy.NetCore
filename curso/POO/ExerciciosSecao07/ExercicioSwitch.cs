//switch-case

//Estrutura opcional a vários if-else encadeados, quando a condição envolve o teste
//do valor de uma variável

namespace curso.POO.ExerciciosSecao07
{
    internal class ExercicioSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("1 - Sunday | 2 - Monday | 3 - Tuesday | 4 - Wednesday" );
            Console.WriteLine("5 - Thursday | 6 - Friday | 7 - Saturday ");
            Console.Write("\nDigite o número corresponde ao dia da semana a ser exibido: ");

            int x = int.Parse(Console.ReadLine());
            string day;
            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine("Day: " + day);
        }
    }
}
