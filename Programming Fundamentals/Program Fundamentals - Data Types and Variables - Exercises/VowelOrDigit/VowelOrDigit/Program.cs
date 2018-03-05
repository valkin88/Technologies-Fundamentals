using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char someSymbol = char.Parse(Console.ReadLine());

            if (someSymbol == 'a' || someSymbol == 'e' || someSymbol == 'y' || someSymbol == 'u' || someSymbol == 'i' || someSymbol == 'o')
            {
                Console.WriteLine("vowel");
            }
            else if (someSymbol >= '0' && someSymbol <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
