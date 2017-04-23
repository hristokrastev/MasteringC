using System;
using System.Collections.Generic;
namespace GroupsContinentsCountriesAndCities
{
    public class GroupsContinentsCountriesAndCities
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var continentsCountriesCities = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            for (int i = 0; i < n; i++)
            {
                var inputInformation = Console.ReadLine().Split();
                var continent = inputInformation[0];
                var country = inputInformation[1];
                var city = inputInformation[2];

                if (!continentsCountriesCities.ContainsKey(continent))
                {
                    continentsCountriesCities[continent] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!continentsCountriesCities[continent].ContainsKey(country))
                {
                    continentsCountriesCities[continent][country] = new SortedSet<string>();
                }
                continentsCountriesCities[continent][country].Add(city);
            }

            foreach (var kvp in continentsCountriesCities)
            {
                var continents = kvp.Key;
                var countriesAndCities = kvp.Value;
                Console.WriteLine($"{continents}:");
                foreach (var contriesAndCitiesPair in countriesAndCities)
                {
                    var country = contriesAndCitiesPair.Key;
                    var city = contriesAndCitiesPair.Value;
                    Console.WriteLine($"  {country} -> {string.Join(", ", city)}");
                }
            }
        }
    }
}
