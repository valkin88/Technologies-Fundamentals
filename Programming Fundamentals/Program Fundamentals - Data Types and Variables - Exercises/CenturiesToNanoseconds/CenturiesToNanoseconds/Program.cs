using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            double days = years * 365.2422f;
            int hours = (int)days * 24;
            decimal minutes = hours * 60M;
            decimal seconds = minutes * 60M;
            decimal milleseconds = seconds * 1000M;
            decimal microseconds = milleseconds * 1000M;
            decimal nanoseconds = microseconds * 1000M;

            Console.WriteLine($"{centuries} centuries = {years} years = {(int)days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milleseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
