using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GC_Lab16
{
    class CountriesTextFile
    {
        public CountriesTextFile()
        {

        }

        public static void ReadCountryList()
        {
            Console.WriteLine(); //This cw is just to create an empty space for clarity.
            var path = "../../../Countries.txt";

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
                Console.WriteLine(line);

            Console.WriteLine(); //This cw is just to create an empty space for clarity.
        }

        public static void AddCountry()
        {
            //getting info
            Console.WriteLine("Enter the name of a country");
            string answer1 = Console.ReadLine();

            while (Validation.StringValidator(answer1))
            {
                Console.WriteLine("The country name cannot be empty or contain numbers. Please try again");
                answer1 = Console.ReadLine();
            }

            Console.WriteLine($"Enter the type of goverment {answer1} is");
            string answer2 = Console.ReadLine();
            while (Validation.StringValidator(answer2))
            {
                Console.WriteLine("The type of Government cannot be empty or contain numbers. Please try again");
                answer2 = Console.ReadLine();
            }

            Console.WriteLine($"Enter the population of {answer1} (in millions, eg: 100 = 100,000,000)");
            string answer3 = Console.ReadLine();
            while (Validation.NumValidator(answer3))
            {
                Console.WriteLine("The population cannot be empty or contain letters. Please try again");
                answer3 = Console.ReadLine();
            }

            Console.WriteLine($"Enter the most common langauge of {answer1}");
            string answer4 = Console.ReadLine();
            while (Validation.StringValidator(answer4))
            {
                Console.WriteLine("The most common langauge cannot be empty or contain numbers. Please try again");
                answer4 = Console.ReadLine();
            }

            List<Countries> countryList = new List<Countries>() { new Countries(answer1, answer2, answer3, answer4) };


            foreach (Countries country in countryList)
            {
                File.AppendAllText("../../../Countries.txt", $"{country.Name}|{country.GovType}|{country.Population}|{country.MainLanguage}" + Environment.NewLine);
            }
            
            Console.WriteLine($"{answer1} has been saved! \n");

        }

    

        public static void CreateAndPopulateTextFile()
        {
            List<Countries> countryList = Countries.GetCountries();

            StreamWriter writer = new StreamWriter("../../../Countries.txt");
            foreach (Countries country in countryList)
            {
                writer.WriteLine($"{country.Name}|{country.GovType}|{country.Population}|{country.MainLanguage}");
            }
            writer.Close();
        }
        
    }
}
