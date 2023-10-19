﻿
using curso.POO.ExerciciosSecao09.Exercicio03.Entities;
using curso.POO.ExerciciosSecao09.Exercicio03.Entities.Enums;
using System.Globalization;

namespace curso.POO.ExerciciosSecao09.Exercicio03;

internal class ExerciseClientOrder
{
    public static void Executar()
    {
        Console.WriteLine("Enter client data: ");
        Console.Write("Name: ");
        string clientName = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter order data: ");
        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        Client client = new Client(clientName, email, birthDate);
        Order order = new Order(DateTime.Now, status, client);

        Console.Write("\nHow many items to this order? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"\nEnter #{i} item data:");
            Console.Write("Product name: ");
            string productName = Console.ReadLine();
            Console.Write("Product price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product product = new Product(productName, price);

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            OrderItem orderItem = new OrderItem(quantity, price, product);

            order.AddItem(orderItem);
        }

        Console.WriteLine();
        Console.Clear();
        Console.WriteLine("ORDER SUMMARY:");
        Console.WriteLine(order);
    }
}
