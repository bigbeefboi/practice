using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeActBoolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string permission = "Admin|Manager";
            int level = 55;
            
            if(permission.Contains("Admin")) 
            {
                if(level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
                
            }else if(permission.Contains("Manager"))
            {
                if(level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else 
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else 
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }*/

            int[] numbers = { 4, 8, 15, 16, 23, 42 };

            int total = 0;
            bool found = false;

            foreach (int number in numbers)
            {


                total += number;

                if (number == 42)
                {
                     found = true;

                }

            }

            if (found)
            {
                Console.WriteLine("Set contains 42");

            }

            Console.WriteLine($"Total: {total}");

            Console.ReadKey();
        }
    }
}
