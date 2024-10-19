using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readResult;
            string valueEntered = "";
            bool isValid = false;
            int num = 0;

            Console.WriteLine("Enter an integer value between 5 and 10");

            do
            {
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                    valueEntered = readResult;
                }

                isValid = int.TryParse(valueEntered, out num);

                if(isValid == true)
                {
                    if(num <= 5 || num >= 10)
                    {
                        isValid = false;
                        Console.WriteLine($"You entered {num}. Please enter a number between 5 and 10.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again");
                }

            } while (isValid==false);

            Console.WriteLine($"Your input value ({num}) has been accepted.");

            Console.ReadKey();
        }
    }
}
