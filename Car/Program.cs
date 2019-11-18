using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = ProsseceFile("fuel.csv");
            cars.ForEach(car =>
            {
                Console.WriteLine(car.Name);

            });
        }

        private static List<Car> ProsseceFile(string path)
        {
            var Data = File.ReadAllLines(path).Skip(1).Where(line => line.Length > 1)
                .Select(line => Car.ParseFromCvc(line)).ToList();
            return Data;
        }


    }
}
