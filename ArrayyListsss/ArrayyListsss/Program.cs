
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayyListsss
{
    class Program
    {
        static void Main(string[] args)
        {
            //create and intialize an array list
            //use the system.collections namespace
            ArrayList myAL = new ArrayList();
            //add values to the arrayList
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            Console.WriteLine("===============");
            Console.WriteLine("myAL");
            Console.WriteLine($" Count: {myAL.Count} ");
            Console.WriteLine($" Capacity: {myAL.Capacity} ");
            Console.Write("Values: ");

            PrintValues(myAL);

            Console.ReadKey();
        }

        public static void PrintValues(ArrayList myAL)
        {
            foreach(var item in myAL)
            {
                Console.Write($" {item}");
            }
        }
    }
}
