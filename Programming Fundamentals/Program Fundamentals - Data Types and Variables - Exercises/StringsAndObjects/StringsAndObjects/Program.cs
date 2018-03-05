using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstStr = "Hello";
            string secondStr = "World";

            object theTwoStrTogether = firstStr + " " + secondStr;

            string thirdStr = (string)theTwoStrTogether;

            Console.WriteLine(thirdStr);
        }
    }
}
