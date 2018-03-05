using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double sum = 0.0;
            //        Water   Coffee  Beer    Tea
            //Price   0.70    1.00    1.70    1.20


            if (profession == "Athlete")
            {
                sum = quantity * 0.70;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                sum = quantity * 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                sum = quantity * 1.70;
            }
            else
            {
                sum = quantity * 1.20;
            }
            Console.WriteLine($"The {profession} has to pay {sum:f2}.");
        }
    }
}
