using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cars = ProcessFile("fuel.csv");

            //Method Syntax 
            //var top = cars.Where(c => c.Manufacturer == "BMW" && c.Year == 2016).OrderByDescending(c => c.Combined).ThenBy(c => c.Name).FirstOrDefault();
            //Console.WriteLine(top);


            //Query Syntax
            //var query = from car in cars
            //            where car.Manufacturer == "BMW" && car.Year == 2016
            //            orderby car.Combined descending, car.Name
            //            select car;



            var result = cars.SelectMany(c => c.Name);

            foreach( var name in result)
            {
                Console.WriteLine(name);
            }

            //foreach (var car in query.Take(10))
            //{
            //    Console.WriteLine($"{car.Manufacturer} {car.Name} : {car.Combined}");
            //}

            Console.ReadLine();
        }

        private static List<Car> ProcessFile(string path)
        {
            var query =
                File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 1)
                .ToCar();

            return query.ToList();

        }
    }

    public static class CarExtension
    {
        public static IEnumerable<Car> ToCar(this IEnumerable<string> source)
        {

            foreach (var line in source)
            {
                var columns = line.Split(',');

                yield return new Car
                {
                    Year = int.Parse(columns[0]),
                    Manufacturer = columns[1],
                    Name = columns[2],
                    Displacement = double.Parse(columns[3]),
                    Cylinders = int.Parse(columns[4]),
                    City = int.Parse(columns[5]),
                    Highway = int.Parse(columns[6]),
                    Combined = int.Parse(columns[7])
                };
            }


        }
    }
}
