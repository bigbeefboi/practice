using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itooa
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Big", "Beef");

            Console.ReadKey();
        }
    }
    class Student
    {
        public string name;
        public string surname;

        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public static void exam()
        {
        }

        public static void register()
        {
        }

    }
}
