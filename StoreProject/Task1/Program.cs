using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Brand = "Mercedes",
                Model = "E200",
                Price = 65000
            };
            Car car2 = new Car
            {
                Brand = "Mercedes",
                Model = "C300",
                Price = 45000
            };
            Car car3 = new Car
            {
                Brand = "Mercedes",
                Model = "S500",
                Price = 120000
            };

            Bicycle bicycle1 = new Bicycle
            {
                Model = "Rambo",
                Brand = "X1"
            };
            Bicycle bicycle2 = new Bicycle
            {
                Model = "Stels",
                Brand = "X2"
            };

            Vehicle[] vehicles = new Vehicle[] { car1, bicycle1, car2, bicycle2, car3 };

            var carCount = CalcCarCount(vehicles);

            Console.WriteLine(carCount);

            var carPrice = FindHigestCarPrice(vehicles);
            Console.WriteLine(carPrice);

        }

        static int CalcCarCount(Vehicle[] vehicles)
        {
            int count = 0;
            for(int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is Car)
                    count++;
            }

            return count;
        }

        static double FindHigestCarPrice(Vehicle[] vehicles)
        {
            double max = 0;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if(vehicles[i] is Car)
                {
                    Car car = vehicles[i] as Car;
                    if (max < car.Price)
                    {
                        max = car.Price;
                    }
                }
            }

            return max;
        }


    }
}
