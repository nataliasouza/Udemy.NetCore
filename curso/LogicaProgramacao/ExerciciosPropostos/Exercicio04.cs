
//Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo,
//sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima
//de 1 hora e máxima de 24 horas.

namespace curso.LogicaProgramacao.ExerciciosPropostos
{
     public class Exercicio04
    {
        public static void Executar()
        {
            Console.Write("Digite a hora inicial do jogo: ");
            int horaInicial = int.Parse(Console.ReadLine());

            Console.Write("Digite a hora Final do jogo: ");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracaoJogo;

            if(horaInicial < horaFinal)
            {
                duracaoJogo = horaFinal - horaInicial;
                Console.WriteLine("\nHoras Totais: " +duracaoJogo);
            }            
            else 
            {
                duracaoJogo = (24 - horaInicial) + horaFinal;
                Console.WriteLine("\nHoras Totais: " + duracaoJogo);
            }
            
            Console.ReadKey();
        }
    }
}
