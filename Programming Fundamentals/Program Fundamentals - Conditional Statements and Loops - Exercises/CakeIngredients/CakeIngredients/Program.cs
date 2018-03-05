using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingrediants = Console.ReadLine();
            int sum = 0;

            for (int i = 1; i <= 20; i++)
            {
                if (ingrediants == "Bake!")
                {
                    break;
                }
                    Console.WriteLine($"Adding ingredient {ingrediants}.");
                    ingrediants = Console.ReadLine();
                    sum++;

            }
            Console.WriteLine($"Preparing cake with {sum} ingredients.");
        }
    }
}
