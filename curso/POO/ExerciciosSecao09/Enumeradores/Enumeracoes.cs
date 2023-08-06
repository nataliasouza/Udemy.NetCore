//Enumerações (enum)

//* É um tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas
//* Palavra chave em C#: enum
//* Nota: enum é um tipo valor
//* Vantagem: melhor semântica, código mais legível e auxiliado pelo compilador

//* Referência: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum

using curso.POO.ExerciciosSecao09.Enumeradores.Entities;
using curso.POO.ExerciciosSecao09.Enumeradores.Enums;

namespace curso.POO.ExerciciosSecao09.Enumeradores;

internal class Enumeracoes
{
    public static void Executar()
    {
        Order order = new Order
        {
            Id = 13,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment
        };

        Console.WriteLine(order);

        //Para o tipo original: use casting

        //mostra o valor do status 2 
        OrderStatus os1 = (OrderStatus)2;
        Console.WriteLine($"\n{os1}");

        //mostra o enum correspondente
        int n1 = (int)OrderStatus.Processing;
        Console.WriteLine($"\n{n1}");

        //convertendo um tipo enum em string

        string enumParaString = OrderStatus.PendingPayment.ToString();
        Console.WriteLine($"\n{enumParaString}");

        //convertendo uma string em um tipo enum

        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        Console.WriteLine($"\n{os}");
    }
}
