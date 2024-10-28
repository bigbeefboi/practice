using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiple variables of the same type can be stored in an array
            //Declare arrays by specifying its elements
            //Arrays can be single-dimensional, multidimensional, or jagged
            //dimensions are set when arrays are declared
            //jagged array is an array of arrays

            //single dimensional array, contains 5 int values
            int[] array1 = new int[5];

            //single dimensional array with values
            int[] array2 = {1, 2, 3, 4, 5, 6 };

            //multiple/2 dimensional array
            int[,] multiArray1 = new int[2, 3];

            //populate the multidimensional array
            int[,] multiArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //jagged array declaration
            int[][] jArray = new int[6][];

            //setting the values of the first array in the jArray
            jArray[0] = new int[4] {1, 2, 3, 4};

            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            
            foreach(string item in weekDays)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
