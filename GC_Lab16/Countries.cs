using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab16
{
    class Countries
    {
        public string Name { get; set; }
        public string GovType { get; set; }
        public string Population { get; set; }
        public string MainLanguage { get; set; }

        public Countries()
        {

        }

        public Countries(string name, string govType, string population, string mainLanguage)
        {
            Name = name;
            GovType = govType;
            Population = population;
            MainLanguage = mainLanguage;
        }

        public static List<Countries> GetCountries()
        {
            List<Countries> countryList = new List<Countries>
            {
                new Countries("USA", "Democratic Republic", "328.2", "English"),
                new Countries("Canada", "Parliamentary Democracy", "37.59", "English"),
                new Countries("Japan", "Constitutional Monarchy", "126.3", "Japanese"),
                new Countries("Russia", "Federal Democracy", "144.4", "Russian")
            };
            return countryList;
        }
    }
}
