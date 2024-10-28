using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIC
{
    class Program
    {
        static void Main(string[] args)
        {
            //update a value in a hashtable
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("key1", "value1");
            dictionary.Add("key2", "value2");

            //update existing keys value
            string keyToUpdate = "key1";
            if (dictionary.ContainsKey(keyToUpdate))
            {
                dictionary[keyToUpdate] = "updatedValue";
            }

            //access that udated value
            string updatedValue;
            if(dictionary.TryGetValue(keyToUpdate, out updatedValue))
            {
                Console.WriteLine("Updated value: " + updatedValue);
            }

            foreach(var item in dictionary)
            {
                Console.WriteLine($"Key: {item.Key} and Value: {item.Value}"  );
            }

            Console.ReadKey();
        }
    }
}
