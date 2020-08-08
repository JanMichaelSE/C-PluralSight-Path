using System;
using System.Collections.Generic;

namespace CSVCountryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\janmm\Documents\VS Code Development\C# Cert Training\PluralSight Beginner\beginner\collections\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            Dictionary<string, Country> countries = reader.ReadAllCountries();

            Console.Write("Enter country code-->");
            string userInput = Console.ReadLine();

            if (countries.ContainsKey(userInput))
            {
                Country country = countries[userInput];
                Console.WriteLine($"{PopulationFormatter.FromatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            else
            {
                Console.WriteLine($"Sorry the code {userInput} does not exist.");
            }
        }
    }
}
