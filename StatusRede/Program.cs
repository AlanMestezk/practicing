
using StatusRede.Entities;
using System;

namespace StatusRede
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("Rede social demo");
            Console.WriteLine();
            
            Comments c1 = new("Loucura cara!");
            Comments c2 = new("Isso é sério? to perplexo");
            Comments c3 = new("Cai nessa não, faz oque te de da vontade");

            Console.Write("Digite o titulo da postagem:  ");
            string title = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite o texto ");
            Console.Write("       da postagem: ");
            string content = Console.ReadLine();


            Post p2 = new(
                 title, content,
                DateTime.Parse("23/12/2034 12:09:55"),
                100
                );

            p2.AddComment(c1);
            p2.AddComment(c2);
            p2.AddComment(c3);

            Console.WriteLine();
            Console.WriteLine("postagem do usuário:");
            Console.WriteLine();
            Console.WriteLine(p2);

        }
    }
}
