using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            //Player player1 = new player("Chad");

            players.Add(new Player("Chad")); //Anonomysly adding an object 
            players.Add(new Player("Steve"));
            players.Add(new Player("Karen"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }

            Console.ReadKey();
        }
    }
}

class Player
{
    public string username;

    public Player(string username)
    {
        this.username = username;
    }

    public override string ToString()//this is to get the string representation/what the object contains not just the object.
    {
        return username;
    }
}
