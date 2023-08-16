
namespace curso.POO.ExerciciosSecao09.Exercicio03.Entities;

internal class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product()
    {
    }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}
