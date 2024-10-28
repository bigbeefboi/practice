using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicelearn
{
    class dog
    {
        public string name;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            dog d1 = new dog();
            d1.age = 12;
            d1.name = "Dog";

            Console.WriteLine(d1.age +" " + d1.name);

            Console.WriteLine("Enter a number");
            int count = 100;
            Console.Write("Enter multiple: ");
            int multiple = Int32.Parse(Console.ReadLine()); //gets user input to take in any multiple
            while (count > 0)
            {
                if (count % multiple == 0) //if there is no remainder it is a multiple

                {
                    Console.WriteLine(count); //displays all multiples
                }
                else
                {
                    Console.WriteLine($"*");
                }
                count -= 1;
            }

            Console.ReadKey();
        }
    }
}
