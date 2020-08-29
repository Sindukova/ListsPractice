using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int num = 1;
            int [] array1 = new int[10];
            for(int i=0; i<array1.Length; i++)
            {
                array1[i] = num;
                num++;

            }

            var evens = new List<int>();


            var odds = new List<int>();

            for (int i =0; i<50; i++)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }
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
            Console.WriteLine("Even numbers from 0 to 50 are: ");
            foreach(var i in evens)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Odd numbers from 0 to 50 are: ");
            foreach (var i in odds)
            {
                Console.WriteLine(i);
            }
        }
    }
}
