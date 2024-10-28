using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleArrayAsArgument
{
    class Program
    {
        static void DisplayArray(string[] array) => Console.WriteLine(string.Join(" ", array));

        static void ReverseArray(string[] array) => Array.Reverse(array);

        static void ChangeArray(string[] array)
        {
            //over write the elements of the array to change them
            array[0] = "Mon";
            array[1] = "Wed";
            array[2] = "Fri";

        }

        static void Main(string[] args)
        {
            //initialize and declare array
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            DisplayArray(weekDays);
            Console.WriteLine();

            //Reverse the array
            ReverseArray(weekDays);
            //Display the array again to show it is reversed
            Console.WriteLine("Using the method to reverse the array the order will be swapped around");
            DisplayArray(weekDays);
            Console.WriteLine();

            //pass array into the method
            ChangeArray(weekDays);
            Console.WriteLine("Using the change array method the index of the array is over written");
            DisplayArray(weekDays);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}