using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, KeyValuePair<double, string>> wheatherInformation = new Dictionary<string, KeyValuePair<double, string>>();
            string cityName = String.Empty;
            double temperatureInCity = 0.0;
            string conditionInCity = String.Empty;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string pattern = @"([A-Z]{2})(\d*\.\d*)([a-zA-Z]+)\|";
                Regex regex = new Regex(pattern);
                MatchCollection collectionOfInformation = regex.Matches(input);
                foreach (Match info in collectionOfInformation)
                {
                    cityName = Convert.ToString(info.Groups[1]);
                    temperatureInCity = Convert.ToDouble(info.Groups[2].Value.ToString());
                    conditionInCity = Convert.ToString(info.Groups[3]);

                    if (!wheatherInformation.ContainsKey(cityName))
                    {
                        wheatherInformation[cityName] = new KeyValuePair<double, string>(temperatureInCity, conditionInCity);

                    }
                    else
                    {
                        wheatherInformation[cityName] = new KeyValuePair<double, string>(temperatureInCity, conditionInCity);
                    
                    }
                   
                }
            }

            foreach (var info in wheatherInformation.OrderBy(x => x.Value.Key).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine($"{info.Key} => {info.Value.Key:f2} => {info.Value.Value}");
            }
        }
    }
}
