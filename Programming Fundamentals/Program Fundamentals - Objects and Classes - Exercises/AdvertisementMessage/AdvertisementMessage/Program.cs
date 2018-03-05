using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            ArraysOfText textOfArrays = new ArraysOfText();
            Random rnd = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {

                Console.WriteLine(textOfArrays.Phrases[rnd.Next(0, textOfArrays.Phrases.Length)] + " "
                                 + textOfArrays.Events[rnd.Next(0, textOfArrays.Events.Length)] + " "
                                 + textOfArrays.Authors[rnd.Next(0, textOfArrays.Authors.Length)] + " - "
                                 + textOfArrays.Cities[rnd.Next(0, textOfArrays.Cities.Length)]);
            }
        }
    }

    public class ArraysOfText
    {
        public string[] Phrases = { "Excellent product.", "Such a great product.",
                             "I always use that product.",
                             "Best product of its category.",
                             "Exceptional product.",
                             "I can’t live without this product." };

        public string[] Events = { "Now I feel good.",
                            "I have succeeded with this product.",
                            "Makes miracles. I am happy of the results!",
                            "I cannot believe but now I feel awesome.",
                            "Try it yourself, I am very satisfied.",
                            "I feel great!" };

        public string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

        public string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
    }
}
