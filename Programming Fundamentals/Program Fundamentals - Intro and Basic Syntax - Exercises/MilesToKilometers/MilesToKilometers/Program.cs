﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            double convertMilesToKm = miles * 1.60934;

            Console.WriteLine("{0:f2}", convertMilesToKm);
        }
    }
}
