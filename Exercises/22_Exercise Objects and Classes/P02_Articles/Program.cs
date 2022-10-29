using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Articles
{
    class Article
    {
        public Article(string str1, string str2, string str3)
        {
            this.Author = str1;
            this.Title = str2;
            this.Content = str3;           
        }

        public string Title { get; set; }  
        public string Content { get; set; }
        public string Author { get; set; }

        public void EditContent(Article art, string str)
        {
            art.Content = str;
        }
        public void ChangeAuthor(Article art, string str)
        {
            art.Author = str;
        }
        public void RenameTitle(Article art, string str)
        {
            art.Title = str;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {            
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();     

            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article article = new Article(author, title, content);

            int numberOFCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOFCommands; i++)
            {
                string command = Console.ReadLine();

                string[] commandArgm = command
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string comma = commandArgm[0];

                if(comma == "Edit")
                {
                    string newContent = commandArgm[1];
                    article.EditContent(article, newContent);
                }
                else if(comma == "ChangeAuthor")
                {
                    string newAuthor = commandArgm[1];
                    article.ChangeAuthor(article, newAuthor);
                }
                else if(comma == "Rename")
                {
                    string newTitle = commandArgm[1];
                    article.RenameTitle(article, newTitle);
                }
            }

            Console.WriteLine(article);
        }        
    }
}
