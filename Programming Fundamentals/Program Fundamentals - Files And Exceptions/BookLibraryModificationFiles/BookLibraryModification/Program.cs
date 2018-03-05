using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("Input.txt");
            int numberOfInputs = int.Parse(inputs[0]);
            Library dataOfBooks = new Library();
            Dictionary<string, DateTime> listOfBooksAndReleaseDates = new Dictionary<string, DateTime>();
            File.Delete("output.txt");
            for (int i = 1; i <= numberOfInputs; i++)
            {
                string[] listOfInformation = inputs[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                dataOfBooks.NameOfBook = listOfInformation[0];
                dataOfBooks.ReleaceDate = DateTime.ParseExact(listOfInformation[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                if (!listOfBooksAndReleaseDates.ContainsKey(dataOfBooks.NameOfBook))
                {
                    listOfBooksAndReleaseDates.Add(dataOfBooks.NameOfBook, dataOfBooks.ReleaceDate);
                }
                else
                {
                    listOfBooksAndReleaseDates[dataOfBooks.NameOfBook] = dataOfBooks.ReleaceDate;
                }

            }

            DateTime givenDate = DateTime.ParseExact(inputs.Last(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var output = listOfBooksAndReleaseDates.Where(x => x.Value > givenDate)
                                                   .OrderBy(x => x.Value)
                                                   .ThenBy(x => x.Key)
                                                   .Select(a => $"{a.Key} -> {a.Value:dd.MM.yyyy}")
                                                   .ToList();

            File.WriteAllLines("output.txt", output);
        }
    }
    public class Library
    {
        public string NameOfBook;
        public DateTime ReleaceDate;
    }
}
