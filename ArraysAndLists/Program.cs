using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            Console.WriteLine(numbers.Length);
           
            
            foreach (int element in numbers)
                if (element % 2 == 0)
                    evenNumbers.Add(element);
                else
                    oddNumbers.Add(element);
            var evensAndOdds = evenNumbers.Zip(oddNumbers, (first, second) => "evens "+ first + " " + " odds " + second);
           foreach (var element in evensAndOdds)
                Console.WriteLine(element);




            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
