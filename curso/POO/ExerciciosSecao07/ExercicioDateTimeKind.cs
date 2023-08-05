//DateTimeKind e padrão ISO 8601

//Tipo enumerado especial que define três valores possíveis para a localidade da data:
//• Local[fuso horário do sistema.Exemplo: São Paulo = GMT - 3 ]
//• Utc [fuso horário GMT(Greenwich Mean Time)]
//• Unspecified

//Boa prática
//• Armazenar em formato UTC (texto: BD / Json / XML)
//• Instanciar e mostrar em formato Local

//Para converter um DateTime para Local ou Utc, você deve usar:
//• myDate.ToLocalTime()
//• myDate.ToUniversalTime()

//Padrão ISO 8601
//•DOC https://www.iso.org/iso-8601-date-and-time-format.html
//•DOC https://en.wikipedia.org/wiki/ISO_8601

//• Formato:
//yyyy - MM - ddTHH:mm: ssZ
//* Z indica que a data/hora está em Utc

namespace curso.POO.ExerciciosSecao07
{
    internal class ExercicioDateTimeKind
    {
        public static void Executar()
        {
            DateTime d11 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d12 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d13 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("d11: " + d11);
            Console.WriteLine("d11 Kind: " + d11.Kind);
            Console.WriteLine("d11 to Local: " + d11.ToLocalTime());
            Console.WriteLine("d11 to Utc: " + d11.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d12);
            Console.WriteLine("d2 Kind: " + d12.Kind);
            Console.WriteLine("d2 to Local: " + d12.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d12.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d13: " + d13);
            Console.WriteLine("d13 Kind: " + d13.Kind);
            Console.WriteLine("d13 to Local: " + d13.ToLocalTime());
            Console.WriteLine("d13 to Utc: " + d13.ToUniversalTime());
            Console.WriteLine();

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
