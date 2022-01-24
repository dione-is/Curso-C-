using System;
using System.Text;

namespace Publicacao.entity {
    class Post {

        public DateTime Moment { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public int Likes { get; private set; }
        public List<Comment> Comment { get; private set; } = new List<Comment>();


        public Post() { 
        
        }

        public Post(DateTime moment, string title, string content, int likes) {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AdicionarComentario(Comment comment) { 
            
            Comment.Add(comment);
        }

        public override string ToString() {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");

            foreach (Comment c in Comment) {
                sb.AppendLine(c.text);
            }
            return sb.ToString();
        }

    }
}
