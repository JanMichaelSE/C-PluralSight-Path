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

            // comment this out to see all countries, without removing the ones with commas
            reader.RemoveCommaCountries(countries);

            Console.Write("Enter no. of countries to display> ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must type in a +ve integer. Exiting");
                return;
            }

            int maxToDisplay = userInput;
            for (int i = countries.Count - 1; i >= 0; i--)
            {
                int displayIndex = countries.Count - 1 - i;
                if (displayIndex > 0 && (displayIndex % maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quit>");
                    if (Console.ReadLine() != "")
                        break;
                }

                Country country = countries[i];
                Console.WriteLine($"{displayIndex + 1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
