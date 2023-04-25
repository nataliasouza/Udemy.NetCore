
namespace curso.POO.ExerciciosSecao06
{
    public struct ExercicioStruct
    {
        public double X, Y;

        public static void Executar()
        {
            ExercicioStruct point;

            point.X = 10;
            point.Y = 20;

            Console.WriteLine(point);

            point = new ExercicioStruct();
            Console.WriteLine(point);

        }

        public override string ToString()
        {
            return "("+ X + "," + Y+ ")";
        }
    }
}
