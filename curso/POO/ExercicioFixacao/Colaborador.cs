//Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em
//seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o
//salário do funcionário com base em uma porcentagem dada (somente o salário bruto é
//afetado pela porcentagem) e mostrar novamente os dados do funcionário.

using System.Globalization;

namespace curso.POO.ExercicioFixacao
{
    public class Colaborador
    {
        public string Nome;
        public double Salario;
        public double SalarioLiquido;
        public double Bonus;
        public int Imposto;

        public static void Executar()
        {
            Colaborador colaborador = new Colaborador();

            Console.Write("Digite o nome do Funcionário: ");
            colaborador.Nome = Console.ReadLine();

            Console.Write("\nDigite o salário bruto: ");
            colaborador.Salario = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            Console.Write("\nDigite o valor do imposto: ");
            colaborador.Imposto = int.Parse(Console.ReadLine());

            colaborador.CalcularSalarioLiquido();
            colaborador.ExibirDadosFuncionario();

            Console.Write("\nDigite a porcentagem do bônus: ");
            int bonus = int.Parse(Console.ReadLine());

            colaborador.AumentarSalario(bonus);
            

            Console.WriteLine("Valor do Bônus: " + colaborador.Bonus.ToString("F2", CultureInfo.InvariantCulture));

            colaborador.ExibirMensagem();
            Console.Clear();

            Console.WriteLine("\n============================================");
            Console.WriteLine(colaborador.ToString());            

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nTotal a receber R$: " + 
                colaborador.CalcularSalarioReceber().ToString("F2", CultureInfo.InvariantCulture));
            Console.ResetColor();
            Console.WriteLine("\n============================================");           
            
        }

        public void AumentarSalario(double porcentagem)
        {
            Bonus += Salario * porcentagem / 100.0;
        }

        public double CalcularSalarioLiquido()
        {
            double desconto = Salario * Imposto / 100.0;
            double salarioComDesconto = Salario - desconto;
            
            SalarioLiquido = salarioComDesconto;

            return SalarioLiquido;
        }

        public double CalcularSalarioReceber()
        {
            return SalarioLiquido + Bonus;
        }

        public void ExibirDadosFuncionario()
        {
            Console.WriteLine("\nNome: " + Nome +
                "\nSalário: " + Salario.ToString("F2",CultureInfo.InvariantCulture) +              
                "\nSalário liquido: " + SalarioLiquido.ToString("F2", CultureInfo.InvariantCulture));
        }

        public override string ToString()
        {
            return "\nNome: " + Nome
            + "\nSalário R$: " + Salario.ToString("F2", CultureInfo.InvariantCulture)
            + "\nSalário liquido R$: " + SalarioLiquido.ToString("F2", CultureInfo.InvariantCulture)
            + "\nBônus R$: " + Bonus.ToString("F2", CultureInfo.InvariantCulture);            

        }

        public void ExibirMensagem()
        {            
            Console.Write("\nAperte uma tecla para prosseguir...");
            Console.ReadKey();
        }
    }
}
