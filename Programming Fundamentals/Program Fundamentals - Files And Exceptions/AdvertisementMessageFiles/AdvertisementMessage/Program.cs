using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfMessages = int.Parse(File.ReadAllText("inputCount.txt"));
            ArraysOfText textOfArrays = new ArraysOfText();
            Random rnd = new Random();
            File.Delete("output.txt");
            for (int i = 0; i < numberOfMessages; i++)
            {

                var text = textOfArrays.Phrases[rnd.Next(0, textOfArrays.Phrases.Length)] + " "
                                 + textOfArrays.Events[rnd.Next(0, textOfArrays.Events.Length)] + " "
                                 + textOfArrays.Authors[rnd.Next(0, textOfArrays.Authors.Length)] + " - "
                                 + textOfArrays.Cities[rnd.Next(0, textOfArrays.Cities.Length)] + Environment.NewLine;

                File.AppendAllText("output.txt", text);
            }
        }
    }

    public class ArraysOfText
    {
        public string[] Phrases = File.ReadAllLines("Phrases.txt");

        public string[] Events = File.ReadAllLines("Events.txt");

        public string[] Authors = File.ReadAllLines("Authors.txt");

        public string[] Cities = File.ReadAllLines("Cities.txt");
    }
}
