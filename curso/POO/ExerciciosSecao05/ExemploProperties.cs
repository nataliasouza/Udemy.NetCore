//Exercício Properties - Aula 56

namespace curso.POO.ExerciciosSecao05
{
    public class ExemploProperties
    {
        public static void Executar()
        {
            Produto07 produto = new Produto07("TV", 4500, 10);

            produto.Nome = "TV 4K";

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.Quantidade);
          
        }
    }
}
