//TimeSpan

//• Representa uma DURAÇÃO
//• É um tipo valor (struct)
//DOC https://msdn.microsoft.com/en-us/library/system.timespan(v=vs.110).aspx

//Construtores
//• TimeSpan()
//• TimeSpan(ticks)
//• TimeSpan(horas, minutos, segundos)
//• TimeSpan(dias, horas, minutos, segundos)
//• TimeSpan(dias, horas, minutos, segundos, milissegundos)

namespace curso.POO.ExerciciosSecao07
{
    internal class Duracoes
    {
        public static void Executar()
        {
            //Demo - construtores

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine();

            //Demo - métodos From

            TimeSpan t11 = TimeSpan.FromDays(1.5);
            TimeSpan t12 = TimeSpan.FromHours(1.5);
            TimeSpan t13 = TimeSpan.FromMinutes(1.5);
            TimeSpan t14 = TimeSpan.FromSeconds(1.5);
            TimeSpan t15 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t16 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t11);
            Console.WriteLine(t12);
            Console.WriteLine(t13);
            Console.WriteLine(t14);
            Console.WriteLine(t15);
            Console.WriteLine(t16);
        }
    }
}
