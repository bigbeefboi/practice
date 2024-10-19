using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {
        static void PrintValue()
        {
            int y = 10 % 3;
            Console.WriteLine(y);
        }
        static void Main(string[] args)
        {

            while (false) {
                int x = 5;
                int y = 3;
                int result = x + y;
                Console.WriteLine(result);
            }


            Console.ReadKey();
        }
    }
}
