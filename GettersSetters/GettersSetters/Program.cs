using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(400);

            car.Speed = 200;

            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }
    }
}
class Car
{
    private int speed;

    public Car(int speed)
    {
        Speed = speed;
    }
    public int Speed
    {
        get { return speed; }//read
        set                  //write
        {
            if (value > 500)
            {
                speed = 500;
            }
            else
            {
                speed = value;
            }
        }
    }
}