using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            //          Small Hall  Terrace    Great Hall
            // Price     2500$	      5000$	     7500$
            // Capacity    50         100         120

            //              Normal   Gold    Platinum
            //  Discount      5 %    10 %      15 %
            // Price        500$	 750$	   1000$

            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();

            double totalPrice = 0.0;
            double discount = 0.0;
            double pricePerPerson = 0.0;

            if (groupSize <= 50)
            {
                if (package == "normal")
                {
                    totalPrice = 2500 + 500;
                    discount = totalPrice * 0.95;
                    pricePerPerson = discount / groupSize;
                }
                else if (package == "gold")
                {
                    totalPrice = 2500 + 750;
                    discount = totalPrice * 0.9;
                    pricePerPerson = discount / groupSize;
                }
                else if (package == "platinum")
                {
                    totalPrice = 2500 + 1000;
                    discount = totalPrice * 0.85;
                    pricePerPerson = discount / groupSize;
                }
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (groupSize <= 100)
            {
                if (package == "normal")
                {
                    totalPrice = 5000 + 500;
                    discount = totalPrice * 0.95;
                    pricePerPerson = discount / groupSize;
                }
                else if (package == "gold")
                {
                    totalPrice = 5000 + 750;
                    discount = totalPrice * 0.9;
                    pricePerPerson = discount / groupSize;
                }
                else if (package == "platinum")
                {
                    totalPrice = 5000 + 1000;
                    discount = totalPrice * 0.85;
                    pricePerPerson = discount / groupSize;
                }
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (groupSize <= 120)
            {
                if (package == "normal")
                {
                    totalPrice = 7500 + 500;
                    discount = totalPrice * 0.95;
                    pricePerPerson = discount / groupSize;
                }
                else if (package == "gold")
                {
                    totalPrice = 7500 + 750;
                    discount = totalPrice * 0.9;
                    pricePerPerson = discount / groupSize;
                }
                else if (package == "platinum")
                {
                    totalPrice = 7500 + 1000;
                    discount = totalPrice * 0.85;
                    pricePerPerson = discount / groupSize;
                }
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
