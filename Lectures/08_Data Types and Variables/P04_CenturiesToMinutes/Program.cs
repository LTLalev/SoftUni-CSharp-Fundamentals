using System;

namespace P04_CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            ushort years = (ushort)(centuries * 100u);
            uint days = (uint)(years * 365.2422);
            ulong hours = days * 24u;
            ulong minutes = hours * 60u;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
