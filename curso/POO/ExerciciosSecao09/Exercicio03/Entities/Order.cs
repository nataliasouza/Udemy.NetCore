﻿
using curso.POO.ExerciciosSecao09.Exercicio03.Entities.Enums;
using System.Globalization;
using System.Text;

namespace curso.POO.ExerciciosSecao09.Exercicio03.Entities;

internal class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public Client Client { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    public Order()
    {
    }

    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        Client = client;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
        Items.Remove(item);
    }

    public double Total()
    {
        double sum = 0.0;
        foreach (OrderItem item in Items)
        {
            sum += item.SubTotal();
        }
        return sum;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Client: " + Client);
        sb.AppendLine("\nOrder moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.AppendLine("Order status: " + Status);        
        sb.AppendLine("\nOrder items:");
        foreach (OrderItem item in Items)
        {
            sb.AppendLine(item.ToString());
        }
        sb.AppendLine("\n\tTotal price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
        return sb.ToString();
    }
}

