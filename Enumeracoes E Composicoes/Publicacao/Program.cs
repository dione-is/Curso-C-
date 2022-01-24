using Publicacao.entity;
using System;

namespace post {
    class Program {
        static void Main(string[] args) {

            Post publicacao = new Post();

            DateTime momento = DateTime.Parse("08/10/2021 09:15:44");
            string titulo = "Ola novo Mundo";
            string conteudo = " projeto desenvolvido em C#";
            int gosteis = 325;


            publicacao = new Post(momento, titulo, conteudo, gosteis );

            Comment comment1 = new Comment("Top demais");
            Comment comment2 = new Comment("Boooa mano");

            publicacao.AdicionarComentario(comment1);
            publicacao.AdicionarComentario(comment2);

            Console.WriteLine(publicacao);
        }
    }
}