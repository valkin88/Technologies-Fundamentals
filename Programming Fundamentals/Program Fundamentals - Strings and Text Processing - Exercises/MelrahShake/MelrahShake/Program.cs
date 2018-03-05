using System;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();


            while (true)
            {
                int firstIndex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);
                if (firstIndex >= 0 && lastIndex >= 0 && firstIndex != lastIndex && pattern.Length > 0)
                {
                    input = input.Remove(lastIndex, pattern.Length);
                    input = input.Remove(firstIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");

                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
           
        }
    }
}
