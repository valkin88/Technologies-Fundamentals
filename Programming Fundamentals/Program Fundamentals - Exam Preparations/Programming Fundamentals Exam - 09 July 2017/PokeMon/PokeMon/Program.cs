using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeTarget = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());
            int result = pokePower;
            int count = 0;


            for (int i = 1; i > 0; i++)
            {
                result = result - pokeTarget;
                count++;
                if (result * 2 == pokePower && exhaustionFactor != 0)
                {
                    result = result / exhaustionFactor;
                }
                if (result < pokeTarget)
                {
                    break;
                }
            }
            Console.WriteLine(result);
            Console.WriteLine(count);
        }
    }
}
