using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("Input.txt");
            Library dataOfAuthorsAndBooks = new Library();
            Dictionary<string, decimal> booksData = new Dictionary<string, decimal>();
            int numberOfInputs = int.Parse(inputs[0]);
            for (int i = 1; i <= numberOfInputs; i++)
            {
                string[] listOfInformation = inputs[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                dataOfAuthorsAndBooks.NameOfAuthor = listOfInformation[1];
                dataOfAuthorsAndBooks.TotalPrice = decimal.Parse(listOfInformation.Last());

                if (!booksData.ContainsKey(dataOfAuthorsAndBooks.NameOfAuthor))
                {
                    booksData.Add(dataOfAuthorsAndBooks.NameOfAuthor, dataOfAuthorsAndBooks.TotalPrice);
                }
                else
                {
                    booksData[dataOfAuthorsAndBooks.NameOfAuthor] += dataOfAuthorsAndBooks.TotalPrice;
                }
                
            }
            var output = booksData.Select(a => $"{a.Key} -> {a.Value:f2}").ToList();
            File.WriteAllLines("output.txt", output);
        }
    }

    public class Library
    {
        public string NameOfAuthor;
        public decimal TotalPrice;
    }
}
