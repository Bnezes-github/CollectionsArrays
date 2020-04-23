using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiation and Display Array
            
            string [] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"

            };

            foreach ( string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("which day do you want to display?");
            Console.Write("(Monday = 1, etc..)> ");
            int indexDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[indexDay -1];
            Console.WriteLine($"That day is {chosenDay}");

            // Array of intergers example

            Console.WriteLine("Before Fix:");
            int[] numberDays = { 1, 22, 3, 4, 5, 6, 7 };
            foreach ( int number in numberDays)
                Console.WriteLine(number);

            Console.WriteLine("\r\n After Fix:");
            numberDays[1] = 2;
            foreach (int number in numberDays)
                Console.WriteLine(number);
        }
    }
}
