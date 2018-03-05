using System;
using System.Linq;
using System.Numerics;

namespace InstructionSet
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isTheEnd = true;

            while (isTheEnd)
            {
                string codeIstruction = Console.ReadLine().ToLower();
                string[] codeArgs = codeIstruction.Split(' ').ToArray();

                if (codeArgs[0] == "end")
                {
                    isTheEnd = false;
                    break;
                }
                else
                {
                    BigInteger result = 0;
                    switch (codeArgs[0])
                    {
                        case "inc":
                            {
                                BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                                result = operandOne + 1;
                                Console.WriteLine(result);
                                break;
                            }
                        case "dec":
                            {
                                BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                                result = operandOne - 1;
                                Console.WriteLine(result);
                                break;
                            }
                        case "add":
                            {
                                BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                                BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                                result = operandOne + operandTwo;
                                Console.WriteLine(result);
                                break;
                            }
                        case "mla":
                            {
                                BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                                BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                                result = operandOne * operandTwo;
                                Console.WriteLine(result);
                                break;
                            }
                    }
                } 
            }
        }
    }
}
