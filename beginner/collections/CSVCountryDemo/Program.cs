using System;

namespace CSVCountryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\janmm\Documents\VS Code Development\C# Cert Training\PluralSight Beginner\beginner\collections\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FromatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
