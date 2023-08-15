
using System.Text;

namespace curso.POO.ExerciciosSecao09.Exercicio02.entities;

internal class Post
{
    public DateTime Moment { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public Post()
    {
        
    }

    public Post(DateTime moment, string title, string content, int likes)
    {
        Moment = moment;
        Title = title;
        Content = content;
        Likes = likes;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void RemoveComment(Comment comment)
    {
        Comments.Remove(comment);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("\nPost Title: " + Title);
        sb.Append(Likes);
        sb.Append(" Likes - ");
        sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.AppendLine("\nPost Content: " + Content);
        sb.AppendLine("\nComments:");
        
        foreach (Comment c in Comments)
        {
            sb.AppendLine("\t"+c.Text);
        }
        sb.AppendLine("\n------------------------------------------");
        return sb.ToString();

    }
}
