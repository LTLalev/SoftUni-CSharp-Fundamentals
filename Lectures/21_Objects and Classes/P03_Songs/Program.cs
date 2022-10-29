using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Songs
{
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] inputArgm = Console.ReadLine()
                    .Split('_', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string typeList = inputArgm[0];
                string name = inputArgm[1];
                string time = inputArgm[2];

                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }

            string input = Console.ReadLine();

            if(input == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs.Where(x => x.TypeList == input))
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
