//Exercício Apostila Curso Completo C#

namespace curso.LogicaProgramacao
{
    public class ContaBancaria
    {
        public string Titular { get; set; }        
        public double Saldo { get; set; }        

        public static void Executar()
        {            
            var contaTeddy = new ContaBancaria();
            contaTeddy.Titular = "Teddy";
            contaTeddy.Saldo = 550;

            Console.WriteLine("Valor do Saldo Inicial: " + contaTeddy.Saldo);
            double saldoInicial = contaTeddy.Saldo;

            Console.Write("\nDigite o deposito para deposito: ");
            double deposito = double.Parse(Console.ReadLine());
            contaTeddy.Deposito(deposito);

            Console.Write("Digite o deposito para saque: ");
            double saque = double.Parse(Console.ReadLine());
            contaTeddy.Saque(saque);

            Console.Clear();
            Console.WriteLine("Titular da conta: " + contaTeddy.Titular);
            Console.WriteLine("Valor do Saldo Inicial: " + saldoInicial);
            Console.WriteLine("Valor do Depósito: " + deposito);
            Console.WriteLine("Valor do Saque: " + saque);      
            Console.WriteLine("Valor do Saldo Atual: " + contaTeddy.GetSaldo());

            //var contaMallu = new ContaBancaria()
            //{
            //    Titular = "Mallu",
            //    Saldo = 1000
            //};

            //contaMallu.Deposito(500);
            //contaMallu.Saque(350);

            Console.ReadKey();
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public double GetSaldo()
        {
            return Saldo;
        }

        public void Saque(double saque)
        {
            Saldo -= saque;
        }

    }
}
