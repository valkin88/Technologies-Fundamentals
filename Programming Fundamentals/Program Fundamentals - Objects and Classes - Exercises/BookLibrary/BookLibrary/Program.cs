using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Library dataOfAuthorsAndBooks = new Library();
            Dictionary<string, decimal> booksData = new Dictionary<string, decimal>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                dataOfAuthorsAndBooks.NameOfAuthor = input[1];
                dataOfAuthorsAndBooks.TotalPrice = decimal.Parse(input.Last());

                if (!booksData.ContainsKey(dataOfAuthorsAndBooks.NameOfAuthor))
                {
                    booksData.Add(dataOfAuthorsAndBooks.NameOfAuthor, dataOfAuthorsAndBooks.TotalPrice);
                }
                else
                {
                    booksData[dataOfAuthorsAndBooks.NameOfAuthor] += dataOfAuthorsAndBooks.TotalPrice;
                }
                
            }


            foreach (var author in booksData.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }
    }

    public class Library
    {
        public string NameOfAuthor;
        public decimal TotalPrice;
    }
}
