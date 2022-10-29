using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_PokemonDon_tGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonDistance = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int index = int.Parse(Console.ReadLine());

            int sum = 0;

            while (true)
            {               
                if(pokemonDistance.Count == 0)
                {
                    break;
                }

                if(index < 0)
                {
                    RemovedElementsIfIndexIsUnderZero(pokemonDistance, index, ref sum);
                   
                }
                else if (index > pokemonDistance.Count - 1)
                {
                    RemovedElementsIfIndexIsGreaterThanCount(pokemonDistance, index, ref sum);                    
                }
                else
                {
                    int removedElement = pokemonDistance[index];
                    sum += removedElement;
                    pokemonDistance.RemoveAt(index);

                    if (pokemonDistance.Count == 0)
                    {
                        break;
                    }

                    RemoveElement(pokemonDistance, removedElement);                    
                }               

                index = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }

        private static void RemoveElement(List<int> pokemonDistance, int removedElement)
        {
            for (int i = 0; i < pokemonDistance.Count; i++)
            {
                if (pokemonDistance[i] <= removedElement)
                {
                    pokemonDistance[i] += removedElement;
                }
                else
                {
                    pokemonDistance[i] -= removedElement;
                }
            }
        }

        private static void RemovedElementsIfIndexIsGreaterThanCount(List<int> pokemonDistance, int index, ref int sum)
        {
            int lastElement = pokemonDistance.Last();
            sum += lastElement;
            pokemonDistance.RemoveAt(pokemonDistance.Count - 1);
            int firstElement = pokemonDistance.First();
            pokemonDistance.Add(firstElement);

            for (int i = 0; i < pokemonDistance.Count; i++)
            {
                if (pokemonDistance[i] <= lastElement)
                {
                    pokemonDistance[i] += lastElement;
                }
                else
                {
                    pokemonDistance[i] -= lastElement;
                }
            }
        }

        private static void RemovedElementsIfIndexIsUnderZero(List<int> pokemonDistance, int index, ref int sum)
        {
            int lastElement = pokemonDistance.Last();
            int firstElement = pokemonDistance.First();
            sum += firstElement;
            int firstIndex = 0;
            pokemonDistance.RemoveAt(firstIndex);
            pokemonDistance.Insert(firstIndex, lastElement);

            for (int i = 0; i < pokemonDistance.Count; i++)
            {
                if (pokemonDistance[i] <= firstElement)
                {
                    pokemonDistance[i] += firstElement;
                }
                else
                {
                    pokemonDistance[i] -= firstElement;
                }
            }
        }
    }
}
