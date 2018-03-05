using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] {','};

            Dictionary<string, List<string>> dictionaryOfFinalScore = new Dictionary<string, List<string>>();
            List<string> listOfCards = new List<string>();
            int sumOfCards = 0;
            string input = Console.ReadLine();
            while (input != "JOKER")
            {

                string[] arrOfInput = input.Split(':');
                string nameOfPerson = arrOfInput[0];
                listOfCards = arrOfInput[1].Split(separators, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();


                if (!dictionaryOfFinalScore.ContainsKey(nameOfPerson))
                {
                    dictionaryOfFinalScore.Add(nameOfPerson, new List<string>());
                }

                foreach (var card in listOfCards)
                {
                    if (!dictionaryOfFinalScore[nameOfPerson].Contains(card))
                    {
                        dictionaryOfFinalScore[nameOfPerson].Add(card);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in dictionaryOfFinalScore)
            {
                string nameOfPerson = player.Key;
                sumOfCards = 0;
                foreach (var cardsOfPplayer in player.Value)
                {
                    string singleCard = cardsOfPplayer.Trim();
                    string power = singleCard.Trim().Substring(0, singleCard.Length - 1);
                    string type = singleCard.Trim().Substring(singleCard.Length - 1);
                    int typeOfCard = FindTypeOfCard(type);
                    int powerOfCard = FindPowerOfCard(power);
                    sumOfCards += typeOfCard * powerOfCard;
                }
                Console.WriteLine($"{nameOfPerson}: {sumOfCards}");
            }
        }

        static int FindTypeOfCard(string typeOfCard)
        {
            int result = 0;
            switch (typeOfCard)
            {
                case "S":
                    result = 4;
                    break;
                case "H":
                    result = 3;
                    break;
                case "D":
                    result = 2;
                    break;
                case "C":
                    result = 1;
                    break;
            }

            return result;
        }

        static int FindPowerOfCard(string powerOfCard)
        {
            int result = 0;
            switch (powerOfCard)
            {
                case "1": result = 1; break;
                case "2": result = 2; break;
                case "3": result = 3; break;
                case "4": result = 4; break;
                case "5": result = 5; break;
                case "6": result = 6; break;
                case "7": result = 7; break;
                case "8": result = 8; break;
                case "9": result = 9; break;
                case "10": result = 10; break;
                case "J": result = 11; break;
                case "Q": result = 12; break;
                case "K": result = 13; break;
                case "A": result = 14; break;
                default:
                    break;
            }
            return result;
        }
    }
}
