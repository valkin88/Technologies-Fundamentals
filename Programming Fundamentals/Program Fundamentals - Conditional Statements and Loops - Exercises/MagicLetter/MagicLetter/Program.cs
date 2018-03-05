using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            for (char i1 = letter1; i1 <= letter2; i1++)
            {
                for (char i2 = letter1; i2 <= letter2; i2++)
                {
                    for (char i3 = letter1; i3 <= letter2; i3++)
                    {
                        if (i1 != letter3 && i2 != letter3 && i3 != letter3)
                        {
                            Console.Write($"{i1}{i2}{i3} ");
                        }
                    }
                }
            }
        }
    }
}
