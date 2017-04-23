using System;
using System.Collections.Generic;
namespace CitiesByContinentAndCountry
{
    public class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var continentInfo = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var continent = line[0];
                var country = line[1];
                var city = line[2];

                if (!continentInfo.ContainsKey(continent))
                {
                    continentInfo[continent] = new Dictionary<string, List<string>>();
                }
                if (!continentInfo[continent].ContainsKey(country))
                {
                    continentInfo[continent][country] = new List<string>();
                }
                continentInfo[continent][country].Add(city);
            }
            foreach (var kvp in continentInfo)
            {
                var continents = kvp.Key;
                var countryAndCities = kvp.Value;
                Console.WriteLine($"{continents}:");
                foreach (var countryAndCitiesPair in countryAndCities)
                {
                    var country = countryAndCitiesPair.Key;
                    var cities = countryAndCitiesPair.Value;
                    Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
