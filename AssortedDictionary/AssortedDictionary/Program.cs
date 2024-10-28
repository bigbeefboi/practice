using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> sorted = new SortedDictionary<int, string>();
            sorted.Add(11, "Eleven");
            sorted.Add(33, "Three");
            sorted.Add(31, "Thirty");
            sorted.Add(1, "One");
            //sorted.Add(1, "One");
            //no duplicates are allowed similar to a hash table

            foreach (var item in sorted)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");

            SortedSet<String> list = new SortedSet<String>();

            for (int i = 0; i < 10; i++)
            {
                int number = i + 1;
                list.Add("Employee number : " + number);
            }


            list.Add("Employee number : " + 1);//this will not print again as duplicates do not print 
            list.Add("Employee number : " + 10);
            list.Add("Employee number : " + 21);





            foreach (String s in list)
            {
                Console.WriteLine(s);
            }
        
    

            Console.ReadKey();
        }
    }
}
