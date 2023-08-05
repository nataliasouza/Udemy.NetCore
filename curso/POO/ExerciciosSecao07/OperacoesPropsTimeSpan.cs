
namespace curso.POO.ExerciciosSecao07
{
    internal class OperacoesPropsTimeSpan
    {
        public static void Executar()
        {
            //Demo: MaxValue, MinValue, Zero
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine();

            //Demo - propriedades
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
            Console.WriteLine();

            //Demo - operações
            TimeSpan t11 = new TimeSpan(1, 30, 10);
            TimeSpan t12 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t11.Add(t12);
            TimeSpan dif = t11.Subtract(t12);
            TimeSpan mult = t12.Multiply(2.0);
            TimeSpan div = t12.Divide(2.0);
            Console.WriteLine(t11);
            Console.WriteLine(t12);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
