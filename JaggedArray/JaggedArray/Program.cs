using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];//the elements of a jagged array are arrays of different sizes

            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };

            int[][] jaggedArray2 =
            {
            new int[] {1, 3, 5, 7, 9},
            new int[] {0, 2, 4, 6},
            new int[] {11, 22}
            };//declaration and initialization of a jagged array

            jaggedArray2[0][1] = 77; //assign value to element 2 of array 1 in jArray2
            jaggedArray2[2][1] = 88;//assign value to element 2 of array 3 in jArray2

            Console.WriteLine(jaggedArray2[0][0]);//write an element from the array



            //declare an array of 2 elements
            int[][] arr = new int[2][];

            //initialize elements
            //a jagged arrays elements elements must be neutralized before they are used 
            //when an array is initialized then it is not required to get its size
            //size is not specified then == GetLength
            //size specified then == Length
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            for(int i = 0; i <arr.Length; i++)
            { 
                Console.Write("Elements({0}) ", i);

                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? " ":" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
