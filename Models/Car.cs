using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericeCar.Models
{
    public enum Fuel
    {
        Full,
        HalfEmpty,
        Empty
    }
    public class Car : ICar
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Fuel Bensin { get; set; } = Fuel.Empty;

        public void RefuelTheCar() 
        {
            Bensin = Fuel.Full;
        }

        public void Drive()
        {
            if (Bensin == Fuel.Full)
            {
                Console.WriteLine($"Driving my {Name} {Model}");
            }
            else
            {
                Console.WriteLine($"Need to refuel ur {Name} {Model}");
            }
        }
    }
}
