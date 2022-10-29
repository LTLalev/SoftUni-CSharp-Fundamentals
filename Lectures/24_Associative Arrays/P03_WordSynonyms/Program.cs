using System;
using System.Collections.Generic;

namespace P03_WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfWord = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordsAndSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < countOfWord; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if(!wordsAndSynonyms.ContainsKey(word))
                {
                    wordsAndSynonyms.Add(word, new List <string>());                    
                }

                wordsAndSynonyms[word].Add(synonym);
            }

            foreach (var kvp in wordsAndSynonyms)
            {
                Console.Write($"{kvp.Key} - ");

                Console.WriteLine(string.Join(", ", kvp.Value));
            }
        }
    }
}
