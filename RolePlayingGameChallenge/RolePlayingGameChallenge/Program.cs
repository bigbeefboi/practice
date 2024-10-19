using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGameChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hero = 10;
            int monster = 10;

            Random r = new Random();
           

            do
            {
                int attack = r.Next(1, 11);
                monster = monster - attack;
                Console.WriteLine( $"Monster was damaged and lost {attack} health and now has {monster} health.");

                if(monster > 0)
                {
                    attack = r.Next(1, 11);
                    hero = hero - attack;
                    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {hero} health.");
                }

            } while (hero > 0 && monster > 0);

            if(hero > monster)
            {
                Console.WriteLine("Hero wins!");
            }
            else
            {
                Console.WriteLine("Monster wins!");
            }

            Console.ReadKey();
        }
    }
}
