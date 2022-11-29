//Placeholders, interpolação e concatenação

using System.Globalization;

namespace curso.LogicaProgramacao
{
    public class Concatenacao
    {        
        public static void Executar()
        {
            int idade = 37;
            double saldo = 13000.8000;
            string nome = "Max";

            Console.WriteLine("{0} tem {1} anos e seu saldo é: {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e seu saldo é: {saldo:F2} reais");
            Console.WriteLine(nome + " tem " + idade + " anos e seu saldo é: " 
                + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
