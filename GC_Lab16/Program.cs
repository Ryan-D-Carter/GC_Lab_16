using System;

namespace GC_Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a countires class with 4 properties (population, age, name, continent)
            // add functionality to delete a country, C.R.U.D.

            CountriesTextFile.CreateAndPopulateTextFile();

            CountriesApp.Play();
        }
    }
}
