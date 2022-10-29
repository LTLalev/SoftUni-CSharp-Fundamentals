using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",  
                "I always use that product.",  
                "Best product of its category.",
                "Exceptional product.", 
                "I can't live without this product."
            };

           string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors = new string[]
            {
                "Diana", 
                "Petya", 
                "Stella", 
                "Elena", 
                "Katya",
                "Iva", 
                "Annie", 
                "Eva"
            };

            string[] cities = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };      

            int numberOfMessage = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMessage; i++)
            {
                Random randomPhrases = new Random();
                var shuffledPhrases = phrases.OrderBy(_ => randomPhrases.Next()).ToList();

                Random randomEvents = new Random();
                var shuffledEvents = events.OrderBy(_ => randomEvents.Next()).ToList();

                Random randomAuthors = new Random();
                var shuffledAuthors = authors.OrderBy(_ => randomAuthors.Next()).ToList();

                Random randomCities = new Random();
                var shuffledCities = cities.OrderBy(_ => randomCities.Next()).ToList();

                Console.WriteLine($"{shuffledPhrases[i]} {shuffledEvents[i]} {shuffledAuthors[i]} – {shuffledCities[i]}.");
            }
        }
    }
}
