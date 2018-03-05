using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine().ToLower();

            //“Water” – for “Athlete”
//“Coffee” – for “Businessman” or “Businesswoman”
//“Beer” – for “SoftUni Student”
//“Tea” – for all other professions.


            if (profession == "athlete")
            {
                Console.WriteLine("Water");
            }
            else if (profession == "businessman" || profession == "businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (profession == "softuni student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
