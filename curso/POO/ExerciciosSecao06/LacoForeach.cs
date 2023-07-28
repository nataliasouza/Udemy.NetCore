//Laço for each

//Sintaxe opcional e simplificada para percorrer coleções
//Leitura: "para cada objeto 'nome' contido em vetorDeNomes, faça:"

namespace curso.POO.ExerciciosSecao06
{
    internal class LacoForeach
    {
        public static void Executar()
        {
            string[] vetorDeNomes = new string[] { "Maria", "Bob", "Alex" };

            foreach (string nome in vetorDeNomes)
            {
                Console.WriteLine($"{nome}");
            }
        }
    }
}
