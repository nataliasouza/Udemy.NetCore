//Exercício Apostila Curso Completo C#

using System.Globalization;

namespace curso.LogicaProgramacao
{
    public class ExeFixacao01
    {
        public static void Executar()
        {
            string computador = "Computador";
            string mesaComputador = "Mesa de Computador";

            double precoComputador = 2100.0;
            double precoMesaComputador = 650.50;
            //double medida = 53.234567;

            Console.WriteLine("==== CRIANDO CADASTRO =====================================\n");
            Console.Write("Digite sua idade: ");
            byte idade = byte.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite seu sexo: \n\t(M ou m => Masculino ou F ou f para Feminino)");
            char genero = char.Parse(Console.ReadLine());
            
            Random numCodigo = new Random();
            int codigo = numCodigo.Next(1,9999);            
            Console.WriteLine("Seu código: " + codigo.ToString());
            Console.WriteLine("===========================================================\n");           
            Console.Write("\nAperte uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("==== REGISTRO CLIENTE ======================================\n");
            Console.WriteLine($"Código cliente: {codigo} \nIdade: {idade} anos \nGênero: {genero}");
            Console.WriteLine("===========================================================\n");
            Console.Write("\nAperte uma tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine("==== PRODUTOS =============================================\n");
            Console.WriteLine($"{computador} \n\tPreço: R$ {precoComputador:F2}");
            Console.WriteLine($"\n{mesaComputador} \n\tPreço: R$ {precoMesaComputador:F2}\n");
            Console.WriteLine("===========================================================");
            Console.Write("\nAperte uma tecla para continuar...");
            Console.ReadKey();            

            //Console.WriteLine($"\nMedida com oito casas decimais: {medida:F8}");
            //Console.WriteLine($"Arredondado (Três casas decimais): {medida:F3}");
            //Console.WriteLine("Separador decimal invariant culture: " 
            //    + medida.ToString("F3", CultureInfo.InvariantCulture));
            //Console.ReadKey();
        }
    }
}
