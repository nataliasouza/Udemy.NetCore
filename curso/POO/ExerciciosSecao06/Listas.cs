//Referência: https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.110).aspx

//• Tamanho da lista: Count

//• Encontrar primeiro ou último elementos da lista que satisfaça um predicado:
//  list.Find, list.FindLast

//• Encontrar primeira ou última posição de elemento da lista que satisfaça um predicado:
//  list.FindIndex, list.FindLastIndex

//• Filtrar a lista com base em um predicado: list.FindAll

//• Remover elementos da lista: RemoveRange

//método Add vai adicionar ao final da lista e Insert podemos definir a posição

namespace curso.POO.ExerciciosSecao06
{
    public class Listas
    {
        public static void Executar()
        {
            //List<string> listaNomes= new List<string> { "Max", "Teddy", "Malu", "Mike"};
            List<string> listaDeNomes = new List<string>();
            listaDeNomes.Add("Max"); 
            listaDeNomes.Add("Teddy");
            listaDeNomes.Add("Malu");
            listaDeNomes.Add("Mike");
            listaDeNomes.Add("Lupy");
            listaDeNomes.Add("Thor");
            listaDeNomes.Insert(4, "Raika");

            foreach (string nome in listaDeNomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("\nList Count (quantidade de elementos na lista): " + listaDeNomes.Count );

            string encontraPrimeiroElemento = listaDeNomes.Find(encontreLetra => encontreLetra[0] == 'M');
            Console.WriteLine("\nFirst 'M': " + encontraPrimeiroElemento);

            string encontraUltimoElemento = listaDeNomes.FindLast(ultimoElemento => ultimoElemento[0] == 'M');
            Console.WriteLine("Last M: " + encontraUltimoElemento);

            int posicao = listaDeNomes.FindIndex(posicaoM => posicaoM[0] == 'M');
            Console.WriteLine("First Position 'M': " + posicao);

            int posicao2 = listaDeNomes.FindLastIndex(ultimoM => ultimoM[0] == 'M');
            Console.WriteLine("First Position 'M': " + posicao2);

            List<string> lista2 = listaDeNomes.FindAll(nome => nome.Length == 5);            
            foreach (string nome in lista2) 
            {
                Console.WriteLine($"{nome}");
            }

            listaDeNomes.Remove("Thor");
            Console.WriteLine("\n=========REMOVE============");
            foreach (string nome in listaDeNomes)
            {
                Console.WriteLine($"{nome}");
            }

            listaDeNomes.RemoveAt(5);
            Console.WriteLine("\n=========REMOVE AT===========");
            foreach(string nome in listaDeNomes)
            {
                Console.WriteLine($"{nome}");
            }

            listaDeNomes.RemoveRange(0,0);
            Console.WriteLine("\n=========REMOVE RANGE=========");
            foreach (string nome in listaDeNomes)
            {
                Console.WriteLine($"{nome}");
            }

            listaDeNomes.RemoveAll(m => m[0] == 'M');
            Console.WriteLine("\n=========REMOVE ALL===========");
            foreach(string nome in listaDeNomes)
            {
                Console.WriteLine($"{nome}");
            }
        }       
    }
}
