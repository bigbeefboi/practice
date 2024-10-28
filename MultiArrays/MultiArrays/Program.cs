using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a 2d array
            //int[,] array2DDeclaration = new int[4,2];
            //declare a 3d array
            //int[,,] array3DDeclaration = new int[4, 2, 3];
            //the first number declares the number of arrays or it is considered as 4 rows & 2 columns
            //these are dimensions of the array

            //initialize a 2d array
            int[,] array2DInitialize = { {1, 2}, {3, 4 }, {5, 6 }, {7, 8 } };
            //initialize a 3d array
            int[,,] array3DInitialize = { { { 1, 2, 3 }, { 4,   5,  6 } },
                                        { { 7, 8, 9 }, { 10, 11, 12 } } };
            //a 3d array can be seen as 2 arrays containing 2 arrays along with the elements in the arrays
            //such as [2, 2, 3] 2 arrays < 2 arrays < 3 elements 

            //writing and displaying the 2 array to the console
            Console.WriteLine("2D Array Output:");
            Console.WriteLine(array2DInitialize[0,0]);
            Console.WriteLine(array2DInitialize[0,1]);
            Console.WriteLine(array2DInitialize[1,0]);
            Console.WriteLine(array2DInitialize[1,1]);
            Console.WriteLine();

            Console.WriteLine("3D Array Output:");// i have selected specific elements from both 2d and 3d
            Console.WriteLine(array3DInitialize[0,0,0]);
            Console.WriteLine(array3DInitialize[0,1,0]);
            Console.WriteLine(array3DInitialize[1,0,0]);
            Console.WriteLine(array3DInitialize[1,1,0]);
            Console.WriteLine();

            //this is to get the total amount of elements or length of a dimension
            var allLength = array3DInitialize.Length;
            var total = 1;

            for(int i = 0; i < array3DInitialize.Rank; i++)
            {
                total *= array3DInitialize.GetLength(0);
            }
            Console.WriteLine($"{allLength} equals {total}");
            Console.WriteLine();

            //iterate through multi dimensional arrays with a foreach loop
            Console.Write("Foreach 2D: ");
            foreach (int item in array2DInitialize)
            {
                Console.Write(item+ " ");
            }

            Console.WriteLine();
            
            Console.Write("Foreach 3D: ");
            foreach(int item in array3DInitialize)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //with multidimensional arrays using nested loops allows for more control for how you want to process the elements
            int[,,] array3D = new int[,,]{ { { 1, 2, 3 }, { 4,   5,  6 } },
                        { { 7, 8, 9 }, { 10, 11, 12 } } };

            Console.WriteLine("Nested output of a multi array");

            for(int i = 0; i < array3D.GetLength(0); i++)
            {
                for(int j = 0; j < array3D.GetLength(1); j++)
                {
                    for(int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write($"{array3D[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
