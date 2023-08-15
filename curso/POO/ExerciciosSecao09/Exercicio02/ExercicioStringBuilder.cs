using curso.POO.ExerciciosSecao09.Exercicio02.entities;

namespace curso.POO.ExerciciosSecao09.Exercicio02
{
    internal class ExercicioStringBuilder
    {
        public static void Executar()
        {
            Post post01 = new Post(
                    DateTime.Parse("21/06/2018 13:05:44"),
                    "Traveling to New Zealand",
                    "I'm going to visit this wonderful country!",
                    12);

            Comment comment01 = new Comment("Have a nice trip!");
            Comment comment02 = new Comment("Wow that's awesome!");
            post01.AddComment(comment01);
            post01.AddComment(comment02);

            
            Post post02 = new Post(
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Good night guys",
                    "See you tomorrow",
                    5);
            Comment comment03 = new Comment("Good night");
            Comment comment04 = new Comment("May the Force be with you");
            post02.AddComment(comment03);
            post02.AddComment(comment04);

            Console.WriteLine(post01);
            Console.WriteLine(post02);
        }
    }
}
