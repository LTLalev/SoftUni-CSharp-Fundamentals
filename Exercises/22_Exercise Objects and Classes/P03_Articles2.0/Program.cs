using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Articles2._0
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
        
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int numberOFArticle = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOFArticle; i++)
            {
                string[] art = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string title = art[0];
                string content = art[1];
                string author = art[2];

                Article article = new Article(author, title, content);
                articles.Add(article);
            }

            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
        }
    }
}
