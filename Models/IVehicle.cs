using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericeCar.Models
{
    public interface IVehicle
    {
        string Name { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        void RefuelTheCar();
        void Drive();
    }
}
