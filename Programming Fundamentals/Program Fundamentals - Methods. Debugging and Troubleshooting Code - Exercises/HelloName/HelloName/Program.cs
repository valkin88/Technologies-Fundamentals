using System;

namespace HelloName
{
    class Program
    {
        static string nameOfPerson = Console.ReadLine();
        static void SayingHelloByName()
        {
            Console.WriteLine("Hello, {0}!", nameOfPerson);
        }

        static void Main(string[] args)
        {
            SayingHelloByName();
        }
    }
}
