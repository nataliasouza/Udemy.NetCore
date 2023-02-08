//Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas,
//o valor que recebe por hora e calcula o salário desse funcionário. A seguir,
//mostre o número e o salário do funcionário, com duas casas decimais.

using System.Globalization;

namespace curso.LogicaProgramacao.ExerciciosPropostos.EstruturaSequencial
{
    public class Sequencial04
    {
        public static void Executar()
        {
            Console.Write("Digite o código do Funcionário: ");
            int codFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas: ");
            double horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor pago em horas: ");
            double valorHoraFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalReceber = horasTrabalhadas * valorHoraFuncionario;
            Console.Clear();

            Console.WriteLine("=================== CALCULAR HORAS TRABALHADAS ================\n");
            Console.WriteLine($"Horas Trabalhadas: {horasTrabalhadas}" );
            Console.WriteLine($"Valor por Hora: {valorHoraFuncionario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nCódigo do funcionário: {codFuncionario} e " +
                $"o valor a receber R$: {totalReceber.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ResetColor();
            Console.WriteLine("\n=============================================================");
        }
    }
}
