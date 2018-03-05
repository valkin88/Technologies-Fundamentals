using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDmg = int.Parse(Console.ReadLine());
            int goshoDmg = int.Parse(Console.ReadLine());

            int peshoHp = 100;
            int goshoHp = 100;

            int counter = 1;

            while (peshoHp > 0 || goshoHp > 0)
            {
                if (counter % 2 == 0 && counter != 0)
                {
                    peshoHp = peshoHp - goshoDmg;
                    if (peshoHp > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHp} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Gosho won in {counter}th round."); break;
                    }
                }
                else
                {
                    goshoHp = goshoHp - peshoDmg;
                    if (goshoHp > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHp} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Pesho won in {counter}th round."); break;
                    }
                }

                if (counter % 3 == 0)
                {
                    peshoHp += 10;
                    goshoHp += 10;
                }
                counter++;
            }
        }
    }
}
