using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab16
{
    class CountriesApp
    {
        public static void Play()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine($"Welcome to the Countries List Application! \n1 - See the list of countries \n2 - Add a country \n3 - Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CountriesTextFile.ReadCountryList();
                        break;

                    case "2":
                        CountriesTextFile.AddCountry();
                        break;

                    case "3":
                        Console.WriteLine("Goodbye!");
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
           
        }
    }
}
