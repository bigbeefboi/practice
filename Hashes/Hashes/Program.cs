using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashes
{
    class Program
    {
        static void Main(string[] args)
        {
            //key cannot be null in a hash table
            //hash function is provided by each key object in the hashtable
            //capacity is the number of elements a hashtable can hold
            //hash function is provided by each key object in the hash table 
            //in a hashtable elements of different types can be stored
            //keys are unique and no duplicates are allowed

            //creating a hashtable
            Hashtable my_hastable1 = new Hashtable();

            //adding key/value with the .Add method
            my_hastable1.Add("A1", "Welcome");
            my_hastable1.Add("A2", "to");
            my_hastable1.Add("A3", "GeeksforGeeks");
            

            Console.WriteLine("Key and Value pairs from my_hashtable1:");

            foreach (DictionaryEntry item in my_hastable1)
            {
                Console.WriteLine($" {item.Key} and {item.Value}");
            }

            Console.WriteLine();

            //hashtables also allow us  to remove elements via 2 methods
            //clear
            //remove
            my_hastable1.Remove("A2");//remove an element via identification of the key
            Console.WriteLine("Key and Value pairs from my_hashtable1 with removed elements:");
            foreach (DictionaryEntry item in my_hastable1)
            {
                Console.WriteLine($" {item.Key} and {item.Value}");
            }

            Console.WriteLine();

            //count the current elements available in the hashtable
            Console.WriteLine($"Elements present in my_hastable1: {my_hastable1.Count}");
            Console.WriteLine();

            //use the .Clear function to wipe the hashtable
            my_hastable1.Clear();
            Console.WriteLine();
            Console.WriteLine($"Elements present in my_hastable1: {my_hastable1.Count}");



            Console.WriteLine();

            //create another hashtable
            //add key & value pairs without the .Add method
            Hashtable my_hashtable2 = new Hashtable()
            {{1, "Hello" },
                {2, 234 },
                {3, 230.45 },
                {4, null}
            };

            Console.WriteLine("Key and Value pairs from my_hashtable2:");

            foreach (var item in my_hashtable2.Keys) 
            {
                Console.WriteLine($" {item} and {my_hashtable2[item]}");
            }


            Console.ReadKey();
        }
    }
}
