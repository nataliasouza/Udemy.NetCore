using System.Globalization;

namespace curso.POO.ExerciciosSecao05
{
    public class ContaBancaria02
    {
        public int Numero { get; private set; } //private set, pois o número não pode ser alterado
        public string Titular { get; set; }
        public double Saldo { get; private set; }//private set, pois o saldo só pode ser alterado através dos métodos

        public ContaBancaria02(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria02(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public static void Executar()
        {
            ContaBancaria02 conta;

            Console.Write("Entre o Número da Conta: ");
            int numero = int.Parse(Console.ReadLine()!);

            Console.Write("Entre com o Nome do Titular da conta: ");
            string nomeTitular = Console.ReadLine()!;            

            Console.Write("Haverá depósito inicial (s/n)? ");
            char respostaDepositoInicial = char.Parse(Console.ReadLine()!);

            Console.Clear();

            if (respostaDepositoInicial == 's' || respostaDepositoInicial == 'S')
            {               
                Console.Write("\nEntre o valor de Depósito Inicial: ");                
                double depositoInicial = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                conta = new ContaBancaria02(numero, nomeTitular, depositoInicial);

                Console.Clear();
                Console.WriteLine($"\n\nO depósito inicial foi realizado com sucesso!" +
                    $"\n\n\t{conta}");
            }
            else
            {
                conta = new ContaBancaria02(numero, nomeTitular);
                Console.WriteLine($"\n\n\t{conta}");

            }
            Console.Write("\n\nSua Conta Bancária foi criada!" +
                " \n\n\t Aperte uma tecla para continuar!");

            Console.ReadKey();

            conta.ExibirContaBancaria();
            Console.Write("\nDeseja fazer um depósito? (s/n) ");
            char respostaDeposito = char.Parse(Console.ReadLine()!);

            if (respostaDeposito == 's' || respostaDeposito == 'S')            
            {
                
                Console.Write("\nEntre um valor para depósito: ");
                double valorDeposito = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                conta.Deposito(valorDeposito);

                Console.Clear();
                Console.WriteLine("\n\nDados da conta atualizados!");
                Console.WriteLine($"\n\tValor do depósito: " + valorDeposito.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine($"\n\t" + conta.ToString());                

            } else
            {
                Console.WriteLine("\n\nDados da conta atualizados!");
                Console.WriteLine($"\t" + conta);
            }

            Console.Write($"\n\nAperte uma tecla para continuar!");
            Console.ReadKey();

            conta.ExibirContaBancaria();
            Console.WriteLine($"Saldo Atual R$: {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.Write("\nDeseja fazer um Saque? (s/n) ");
            char respostaSaque = char.Parse(Console.ReadLine()!);

            Console.Clear();

            if (respostaSaque == 's' || respostaSaque == 'S')
            {
                Console.WriteLine($"Saldo Atual R$: {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.Write("\nEntre um valor para saque: ");
                double valorSaque = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                conta.Saque(valorSaque);

                Console.Clear();
                Console.WriteLine("\n\nDados da conta atualizados!");
                Console.WriteLine("\nFoi cobrado R$ 5,00 de taxa pelo saque!");
                Console.WriteLine($"\n\tValor do Saque: " + valorSaque.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine($"\n\t" + conta.ToString());

            } else
            {
                Console.WriteLine("\n\nDados da conta atualizados!");
                Console.WriteLine($"\t" + conta.ToString());
            }
                        
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public void ExibirContaBancaria()
        {
            Console.Clear();
            Console.WriteLine("\n=========================================================");
            Console.WriteLine("\t\tDADOS DA CONTA BANCÁRIA");
            Console.WriteLine("\n=========================================================\n");
            Console.WriteLine($"\tConta: " + Numero);
            Console.WriteLine($"\tNome do Titular: " + Titular);
            Console.WriteLine("\n=========================================================");
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo R$: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
