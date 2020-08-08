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

            List<Country> countries = reader.ReadAllCountries();
            Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
            // Inserts a Value in the desired index
            int lilliputIndex = countries.FindIndex(x => x.Population < 2_000_000);
            countries.Insert(lilliputIndex, lilliput);

            // Removes the index we specifiy in the list
            countries.RemoveAt(lilliputIndex);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FromatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
