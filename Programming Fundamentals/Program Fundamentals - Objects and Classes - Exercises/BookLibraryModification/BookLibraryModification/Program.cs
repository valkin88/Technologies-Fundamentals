using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Library dataOfBooks = new Library();
            Dictionary<string, DateTime> listOfBooksAndReleaseDates = new Dictionary<string, DateTime>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                dataOfBooks.NameOfBook = input[0];
                dataOfBooks.ReleaceDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                if (!listOfBooksAndReleaseDates.ContainsKey(dataOfBooks.NameOfBook))
                {
                    listOfBooksAndReleaseDates.Add(dataOfBooks.NameOfBook, dataOfBooks.ReleaceDate);
                }
                else
                {
                    listOfBooksAndReleaseDates[dataOfBooks.NameOfBook] = dataOfBooks.ReleaceDate;
                }

            }

            DateTime givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            foreach (var book in listOfBooksAndReleaseDates.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                if (book.Value > givenDate)
                {
                    Console.WriteLine($"{book.Key} -> {book.Value:dd.MM.yyyy}");
                }
            }
        }
    }

    public class Library
    {
        public string NameOfBook;
        public DateTime ReleaceDate;
    }
}
