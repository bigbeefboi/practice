using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArrayAsArgument
{
    class Program
    {
        static void PrintArray(int[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++) 
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Element({0},{1}) = {2}" , i, j, array[i, j]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] array2D = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            PrintArray(array2D);

            Console.ReadKey();
        }
    }
}
