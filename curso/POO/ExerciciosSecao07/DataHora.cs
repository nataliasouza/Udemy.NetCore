﻿//DateTime

//• Representa um INSTANTE
//• É um tipo valor (struct)
//DOC https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx

//Instanciação

//• Construtores
//• DateTime(ano, mes, dia)
//• DateTime(ano, mes, dia, hora, minuto, segundo)[opcional: kind]
//• DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo)[opcional: kind]
//• Builders
//• DateTime.Now
//• DateTime.UtcNow
//• DateTime.Today [time: 00:00:00]
//• DateTime.Parse(string)
//• DateTime.ParseExact(string, string)

using System.Globalization;

namespace curso.POO.ExerciciosSecao07
{
    internal class DataHora
    {
        public static void Executar()
        {
            //Demo - construtores

            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine();

            //Demo - Now, UtcNow, Today

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Today;
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine();

            //Demo - Parse

            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine();

            //Demo - ParseExact
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
            CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
        }
    }
}
