using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngrediants = int.Parse(Console.ReadLine());

            int totalCalories = 0;

            for (int i = 1; i <= numberOfIngrediants; i++)
            {
                string ingrediant = Console.ReadLine().ToLower();
                if (ingrediant == "cheese")
                {
                    totalCalories += 500;
                }
                else if (ingrediant == "tomato sauce")
                {
                    totalCalories += 150;
                }
                else if (ingrediant == "salami")
                {
                    totalCalories += 600;
                }
                else if (ingrediant == "pepper")
                {
                    totalCalories += 50;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
