using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDllv2
{
    class Vehicle : IDrivable
    {

        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }
        public Vehicle(string brand = "No brand", int wheels = 0, double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }
        public void Move()
        {
            Console.WriteLine($"The {Brand} Moves forward at {Speed} KM/H");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Brand} stops");
            Speed = 0;
        }
    }
}
