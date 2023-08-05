//Propriedades e Operações com DateTime

//Propriedades
//• Date (DateTime)
//• Day(int)
//• DayOfWeek(DayOfWeek)
//• DayOfYear(int)
//• Hour(int)
//• Kind(DateTimeKind)
//• Millisecond(int)
//• Minute(int)
//• Month(int)
//• Second(int)
//• Ticks(long)
//• TimeOfDay(TimeSpan)
//• Year(int)


using System;

namespace curso.POO.ExerciciosSecao07
{
    internal class OperacoesPropsDateTime
    {
        public static void Executar()
        {
            DateTime dataHora = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(dataHora);
            Console.WriteLine("1) Date: " + dataHora.Date);
            Console.WriteLine("2) Day: " + dataHora.Day);
            Console.WriteLine("3) DayOfWeek: " + dataHora.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + dataHora.DayOfYear);
            Console.WriteLine("5) Hour: " + dataHora.Hour);
            Console.WriteLine("6) Kind: " + dataHora.Kind);
            Console.WriteLine("7) Millisecond: " + dataHora.Millisecond);
            Console.WriteLine("8) Minute: " + dataHora.Minute);
            Console.WriteLine("9) Month: " + dataHora.Month);
            Console.WriteLine("10) Second: " + dataHora.Second);
            Console.WriteLine("11) Ticks: " + dataHora.Ticks);
            Console.WriteLine("12) TimeOfDay: " + dataHora.TimeOfDay);
            Console.WriteLine("13) Year: " + dataHora.Year);
            Console.WriteLine();

            //Formatação(DateTime-> string)

            DateTime dataHora02 = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = dataHora02.ToLongDateString();
            string s2 = dataHora02.ToLongTimeString();
            string s3 = dataHora02.ToShortDateString();
            string s4 = dataHora02.ToShortTimeString();
            string s5 = dataHora02.ToString();
            string s6 = dataHora02.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = dataHora02.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine();

            //Operações com Datetime
            DateTime x = DateTime.Now;
            

            //DateTime y = x.Add(timeSpan);
            DateTime a = x.AddDays(7);
            DateTime b = x.AddHours(13.5);
            DateTime c = x.AddMilliseconds(150);
            DateTime d = x.AddMinutes(35);
            DateTime e = x.AddMonths(1);
            DateTime f = x.AddSeconds(20);
            DateTime g = x.AddTicks(90000);
            DateTime h = x.AddYears(1);
            //DateTime i = x.Subtract(timeSpan);
            //TimeSpan j = x.Subtract(dateTime);
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
        }
    }
}
