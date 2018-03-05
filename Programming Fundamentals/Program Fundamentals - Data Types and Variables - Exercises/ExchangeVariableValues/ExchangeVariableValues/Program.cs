using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Before:\n a = {a}\n b = {b}");
            int c = a;
            int d = b;
            

            a = d;
            b = c;

            Console.WriteLine($"After:\n a = {a}\n b = {b}");
        }
    }
}
