//Exercício: Auto Properties - Aula 57

namespace curso.POO.ExerciciosSecao05
{
    public class ExemploAutoProperties
    {
        public static void Executar()
        {
            Produto08 produto = new Produto08("TV", 4500, 10);

            produto.Nome = "TV 4K";
           
            //produto.Preco = 5500; //por conta do private set, não pode alterar o valor.

            produto.AlterarPreco(5000); //só foi possível alterar o preço por causa do método AlterarPreco()

            produto.Quantidade = 15; //é possivel atribuir um novo valor, pois o atributo está público

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.Quantidade);

        }
    }
}
