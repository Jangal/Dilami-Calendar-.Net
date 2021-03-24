using Dilami_Calendar_.Net;
using System;

namespace C_Sharp_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            DilamiCalendar dc = new DilamiCalendar(1400, 1, 5);

            Console.Write("Dilami Day: ");
            Console.WriteLine(dc.getDilamiDay());
            Console.Write("Dilami Month: ");
            Console.WriteLine(dc.getDilamiMonth());
            Console.Write("Dilami Year: ");
            Console.WriteLine(dc.getDilamiYear());

            Console.WriteLine();

            Console.WriteLine("IS " + dc.getDilamiYear() + " leap year? ");
            if (dc.isLeap())
            {
                Console.WriteLine("Yes!");
            }
            else
            {
                Console.WriteLine("No!");
            }

            Console.WriteLine();

            Console.Write("Jalali Day: ");
            Console.WriteLine(dc.getJalaliDay());
            Console.Write("Jalali Month: ");
            Console.WriteLine(dc.getJalaliMonth());
            Console.Write("Jalali Year: ");
            Console.WriteLine(dc.getJalaliYear());

            Console.ReadLine();
        }
    }
}
