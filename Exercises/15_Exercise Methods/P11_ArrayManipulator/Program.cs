using System;
using System.Collections.Generic;
using System.Linq;

namespace P11_ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArgm = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = inputArgm[0];

                if(command == "exchange")
                {
                    ExchangeElements(ref numbers, inputArgm);                   
                }
                else if (command == "max")
                {
                    GetAndPrintMaxElements(numbers, inputArgm);
                   
                }
                else if(command == "min")
                {
                    GetAndPrintMinElements(numbers, inputArgm);
                   
                }
                else if(command == "first")
                {
                    GetAndPrintFirstElements(numbers, inputArgm);                    
                }
                else if (command == "last")
                {
                    GetAndPrintLastElements(numbers, inputArgm);                    
                }
               
                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        static void ExchangeElements(ref int[] numbers, string[] inputArgm)
        {
            int index = int.Parse(inputArgm[1]);

            if (index < 0 || index > numbers.Length - 1)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {                
                int[] exchangeArray = new int[numbers.Length];
                int currentIndex = 0;
                
                for (int i = index + 1; i < numbers.Length; i++)
                {
                    exchangeArray[currentIndex] = numbers[i];
                    currentIndex++;
                }

                for (int i = 0; i <= index; i++)
                {
                    exchangeArray[currentIndex] = numbers[i];
                    currentIndex++;
                }

                numbers = exchangeArray;
            }
        }
        static void GetAndPrintMaxElements(int[] numbers, string[] inputArgm)
        {
            string maxOddOrEven = inputArgm[1];

            if (maxOddOrEven == "even")
            {
                if (!numbers.ToList().Any(x => x % 2 == 0))
                {
                    Console.WriteLine("No matches");
                }
                else
                {                   
                    int maxNumber = numbers.Where(x => x % 2 == 0).Max();
                    int index = numbers.ToList().LastIndexOf(maxNumber);
                    Console.WriteLine($"{index}");
                }
            }
            else
            {
                if (!numbers.ToList().Any(x => x % 2 != 0))
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    int maxNumber = numbers.Where(x => x % 2 != 0).Max();
                    int index = numbers.ToList().LastIndexOf(maxNumber);
                    Console.WriteLine($"{index}");
                }
            }
        }
        static void GetAndPrintMinElements(int[] numbers, string[] inputArgm)
        {
            string minOddOrEven = inputArgm[1];

            if (minOddOrEven == "even")
            {
                if (!numbers.ToList().Any(x => x % 2 == 0))
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    int minNumber = numbers.Where(x => x % 2 == 0).Min();
                    int index = numbers.ToList().LastIndexOf(minNumber);
                    Console.WriteLine($"{index}");
                }
            }
            else
            {
                if (!numbers.ToList().Any(x => x % 2 != 0))
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    int minNumber = numbers.Where(x => x % 2 != 0).Min();
                    int index = numbers.ToList().LastIndexOf(minNumber);
                    Console.WriteLine($"{index}");
                }
            }
        }
        static void GetAndPrintFirstElements(int[] numbers, string[] inputArgm)
        {
            int count = int.Parse(inputArgm[1]);
            string typeNumber = inputArgm[2];            

            if (count < 0 || count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List <int> numb = new List<int>();

                if (typeNumber == "even")
                {
                    int currentIndex = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            numb.Add(numbers[i]);
                            currentIndex++;
                        }

                        if (currentIndex == count)
                        {
                            break;
                        }
                    }
                    
                    Console.WriteLine($"[{string.Join(", ", numb)}]");
                }
                else
                {
                    int currentIndex = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            numb.Add(numbers[i]);
                            currentIndex++;
                        }

                        if (currentIndex == count)
                        {
                            break;
                        }
                    }
                   
                    Console.WriteLine($"[{string.Join(", ", numb)}]");
                }
            }
        }
        static void GetAndPrintLastElements(int[] numbers, string[] inputArgm)
        {
            int count = int.Parse(inputArgm[1]);
            string typeNumber = inputArgm[2];

            if (count < 0 || count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
               List<int> numb = new List <int>();
                if (typeNumber == "even")
                {
                    int currentIndex = 0;
                    for (int i = numbers.Length - 1; i >= 0; i--)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            numb.Add(numbers[i]);
                            currentIndex++;
                        }

                        if (currentIndex == count)
                        {
                            break;
                        }
                    }

                    numb.Reverse();
                    Console.WriteLine($"[{string.Join(", ", numb)}]");
                }
                else
                {
                    int currentIndex = 0;
                    for (int i = numbers.Length - 1; i >= 0; i--)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            numb.Add(numbers[i]);
                            currentIndex++;
                        }

                        if (currentIndex == count)
                        {
                            break;
                        }
                    }

                    numb.Reverse();
                    Console.WriteLine($"[{string.Join(", ", numb)}]");
                }
            }
        }
    }
}
