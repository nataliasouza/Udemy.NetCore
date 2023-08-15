﻿//Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário).
//Depois, solicitar do usuário um mês e mostrar qual foi o salário do funcionário
//nesse mês, conforme exemplo (próxima página).

using curso.POO.ExerciciosSecao09.Exercicio01.entities.enums;
using curso.POO.ExerciciosSecao09.Exercicio01.entities;
using System.Globalization;

namespace curso.POO.ExerciciosSecao09.Exercicio01;

internal class ExercicioComposicao01
{
    public static void Executar()
    {
        Console.Write("Enter department's name: ");
        string deptName = Console.ReadLine();
        Console.WriteLine("Enter worker data:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Level: (Junior/MidLevel/Senior): ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        Console.Write("Base salary: ");
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Department dept = new Department(deptName);
        Workerman worker = new Workerman(name, level, baseSalary, dept);

        Console.Write("How many contracts to this worker? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Enter #{i} contract data:");
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Duration (hours): ");
            int hours = int.Parse(Console.ReadLine());
            HourContract contract = new HourContract(date, valuePerHour, hours);
            worker.AddContract(contract);
        }

        Console.WriteLine();
        Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        string monthAndYear = Console.ReadLine();
        int month = int.Parse(monthAndYear.Substring(0, 2));
        int year = int.Parse(monthAndYear.Substring(3));
        Console.WriteLine("Name : " + worker.Name);
        Console.WriteLine("Department: " + worker.Department.Name);
        Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
    }
}
