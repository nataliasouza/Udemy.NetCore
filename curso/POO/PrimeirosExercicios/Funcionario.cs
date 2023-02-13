//Fazer um programa para ler nome e salário de dois funcionários.
//Depois, mostrar o salário médio dos funcionários.

using System.Globalization;

namespace curso.POO.PrimeirosExercicios
{
    public class Funcionario
    {
        public string Nome;
        public double Salario;

        public static void Executar()
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.Write("Digite o nome do Colaborador: ");
            funcionario1.Nome = Console.ReadLine();

            Console.Write("Digite o salário: ");
            funcionario1.Salario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o nome do Colaborador: ");
            funcionario2.Nome = Console.ReadLine();

            Console.Write("Digite o salário: ");
            funcionario2.Salario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalarios = CalcularMediaSalarial(funcionario1.Salario, funcionario2.Salario);

            Console.WriteLine($"A média de salários é: {mediaSalarios.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static double CalcularMediaSalarial(double salario1, double salario2)
        {
            double media = (salario1 + salario2) / 2.0;
            return media;
        }
    }
}
