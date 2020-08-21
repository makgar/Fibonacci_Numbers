using System;

namespace Fibonacci_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            Console.WriteLine("Please note that I consider 0 to be F0!" + Environment.NewLine + "Which Fibonnaci sequence number do you wish to get the value for?");
            while (!uint.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine(Environment.NewLine + "Value that you have provided is not a positive integer. Please try again." + Environment.NewLine + "Which Fibonnaci sequence number do you wish to get the value for?");
            }

            uint number;
            switch(n)
            {
                case 0:
                    number = 2;
                    break;
                case 1:
                    number = 2;
                    break;
                default:
                    number = n + 1;
                    break;
            }

            ulong[] F = new ulong[number];
            F[0]= 0;
            F[1]= 1;
            for (uint i = 2; i <= n; i++)
            {
                F[i] = F[i - 2] + F[i - 1];
            }
            Console.WriteLine(Environment.NewLine + "Fibonacci sequence number " + n + " equals:" + Environment.NewLine + F[n] + Environment.NewLine);
            Console.WriteLine("The whole sequence up until element " + n + " is:");
            for (uint i = 0; i <= n; i++)
            {
                Console.Write(F[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
