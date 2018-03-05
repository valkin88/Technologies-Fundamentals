using System;

namespace PrintPartОfТheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberOfSymbol = int.Parse(Console.ReadLine());
            int secondNumberOfSymbol = int.Parse(Console.ReadLine());

            for (int i = firstNumberOfSymbol; i <= secondNumberOfSymbol; i++)
            {
                Console.Write("{0} ", (char)i);
            }
            Console.WriteLine();
        }
    }
}
