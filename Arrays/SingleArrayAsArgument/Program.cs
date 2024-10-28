using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleArrayAsArgument
{
    class Program
    {
        static void DisplayArray(string[] array)
        {
            foreach(string item in array)
            {
                Console.Write(string.Join(" ", item));
            }
        }

        static void Main(string[] args)
        {
            //initialize and declare array
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            DisplayArray(weekDays);
            Console.ReadKey();
        }
    }
}
