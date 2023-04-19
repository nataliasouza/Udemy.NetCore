//Exercício de encapsulamento, utilando a classe Produto06.
//Aula 55

namespace curso.POO.ExerciciosSecao05
{
    public class Exemplo
    {
        public static void Executar()
        {
            Produto06 produto = new Produto06("TV", 4500, 10);


            //Foi feita restrição de acesso e alteração de dados, não é possível atribuir 
            //um novo valor para preço e nem para quantidade, pois não foi criada a função Set(),
            //justamente para proteger esse dado de ser alterado. Só é possível obter os valores.
            //Um atributo private não pode ser acessado diretamente por outra classe.

            //produto._preco = 100.00
            //produto._quantidade = 50;

            //Foi possível passar um novo valor para o nome, pois foi definido um método Set() para nome,
            //que permite através dessa função, atibuir um novo valor.
            produto.SetNome("TV 4K");

            Console.WriteLine(produto.GetNome());
            Console.WriteLine(produto.GetPreco());
            Console.WriteLine(produto.GetQuantidade());
        }
    }
}
