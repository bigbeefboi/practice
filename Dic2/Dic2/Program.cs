using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dic2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a dictionary of type strings key/value pair
            Dictionary<string, string> openWith = new Dictionary<string, string>();

            //add elements to the dictionary entry
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "word.exe");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("An element with key type already exists");
            }

            Console.WriteLine("For key = \"bmp\", value = {0}. ", openWith["bmp"]);

            //if a key does not exist then setting the indexer for that key adds a new key/value pair
            openWith["doc"] = "win.exe";

            Console.WriteLine("For key = \"doc\", value = {0}. ", openWith["doc"]);

            foreach(KeyValuePair<string, string> item in openWith)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
            }

            //remove key
            openWith.Remove("doc");

            if(!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key does not exist");
            }

            //get keys alone
            Dictionary<string, string>.KeyCollection kColl = openWith.Keys;

            foreach(string s in kColl)
            {
                Console.WriteLine($"Key {s}");
            }

            Dictionary<string, string>.ValueCollection vColl = openWith.Values;
            foreach (string s in vColl)
            {
                Console.WriteLine($"Value {s}");
            }

            Console.ReadKey();
        }
    }
}
