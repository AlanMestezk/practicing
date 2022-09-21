
using System.Text;

namespace StatusRede.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comments> Comments { get; set; } = new List<Comments>();

        public Post() { }

        public Post(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public Post(string title, string content, DateTime moment, int likes)
        {
            Title = title;
            Content = content;
            Moment = moment;
            Likes = likes;
        }

        public void AddComment(Comments comments)
        {
            Comments.Add(comments);
        }

        public void RemoveComment(Comments comments)
        {
            Comments.Remove(comments);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"     {Title}");
            sb.AppendLine($"   {Content}");
            sb.AppendLine(" ");
            sb.AppendLine($"data da postagem: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"{Likes} likes ");
            sb.AppendLine(" ");
            sb.AppendLine($"comentários:");
            
            foreach(Comments c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }

    }
}
