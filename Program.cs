using GenericeCar.Models;

namespace GenericeCar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var listOfCars = new List<Car>()
            {
                new Car
                {
                    Name = "BMW",
                    Model = "X6",
                    Year = 2020
                },
                new Car
                {
                    Name = "Saab",
                    Model = "900 Turbo",
                    Year = 1983
                },
                new Car
                {
                    Name = "Audi",
                    Model= "e-tron GT",
                    Year = 2022
                },
                new Car
                {
                    Name = "Kia",
                    Model = "Ceed",
                    Year = 2021
                },
            };

            listOfCars.Remove(listOfCars[2]);
            listOfCars.Insert(2,
                new Car
                {
                    Name = "Volvo",
                    Model = "XC60",
                    Year = 2025
                });

            listOfCars[0].Drive();
            listOfCars[0].RefuelTheCar();
            listOfCars[0].Drive();
        }
    }
}
