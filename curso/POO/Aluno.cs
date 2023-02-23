//Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
//(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
//ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o
//aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este
//problema.

using System.Globalization;

namespace curso.POO
{
    public class Aluno
    {
        public string Nome;
        public double NotaPrimeiroTrimestre;
        public double NotaSegundoTrimestre;
        public double NotaTerceiroTrimestre;

        public static void Executar()
        {
            Aluno aluno = new Aluno();  

            Console.Write("Digite a nome do aluno(a): ");
            aluno.Nome = Console.ReadLine();

            Console.Write("\nPrimeiro Trimestre 30 pontos - Segundo e Terceiro Trimestre 35 pontos." +
                "\n\n\tDigite as 3 notas separadas por espaço e na mesma linha: ");
            string[] notas = Console.ReadLine().Split(' ');

            aluno.NotaPrimeiroTrimestre = double.Parse(notas[0], CultureInfo.InvariantCulture);            
            aluno.NotaSegundoTrimestre = double.Parse(notas[1], CultureInfo.InvariantCulture);            
            aluno.NotaTerceiroTrimestre = double.Parse(notas[2], CultureInfo.InvariantCulture);

            Console.Write("\n\tMédia Ponderada das notas: " 
                + aluno.MediaPonderada().ToString("F2", CultureInfo.InvariantCulture));

            aluno.Aprovado();

        }

        public double NotaFinal()
        {
            return NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiroTrimestre;
        }

        public double MediaPonderada()
        {
            double media = (NotaPrimeiroTrimestre * 30.0 
                + NotaSegundoTrimestre * 35.0 
                + NotaTerceiroTrimestre * 35.0) / 100.0;

            return media;
        }

        public void Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                Console.WriteLine("\n\n\tNome Aluno(a): " + Nome);
                Console.WriteLine("\tNOTA FINAL = " 
                    + NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t APROVADO(A)! ");
                Console.ResetColor();
                Console.WriteLine("\tFaltaram 0.0 pontos para obter a média!");
            }
            else
            {
                double pontos = 60.0 - NotaFinal();
                Console.WriteLine("\n\n\tNome Aluno(a): " + Nome);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t REPROVADO(A)! ");
                Console.ResetColor();
                Console.WriteLine("\tFALTARAM "
                + pontos.ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }
        }
    }
}
