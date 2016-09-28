using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tens = n / 10;
            int ones = n % 10;
            if (tens == 2)
            {
                Console.Write("twenty");
            }
            if (tens == 3)
            {
                Console.Write("thirty");
            }
            if (tens == 4)
            {
                Console.Write("fourty");
            }
            if (tens == 5)
            {
                Console.Write("fifty");
            }
            if (tens == 6)
            {
                Console.Write("sixty");
            }
            if (tens == 7)
            {
                Console.Write("seventy");
            }
            if (tens == 8)
            {
                Console.Write("eighty");
            }
            if (tens == 9)
            {
                Console.Write("ninety");
            }

            //----------------
            if (ones == 2)
            {
                Console.Write("two");
            }
            if (ones == 3)
            {
                Console.Write("three");
            }
            if (ones == 4)
            {
                Console.Write("four");
            }
            if (ones == 5)
            {
                Console.Write("five");
            }
            if (ones == 6)
            {
                Console.Write("six");
            }
            if (ones == 7)
            {
                Console.Write("seven");
            }
            if (ones == 8)
            {
                Console.Write("eight");
            }
            if (ones == 9)
            {
                Console.Write("nine");
            }

            Console.WriteLine();
            if (tens == 1)
            {
                if (ones == 1)
                {
                    Console.Write("eleven");
                }
                if (ones == 2)
                {
                    Console.Write("twelve");
                }
                if (ones == 3)
                {
                    Console.Write("thirteen");
                }
                if (ones == 4)
                {
                    Console.Write("fourteen");
                }
                if (ones == 5)
                {
                    Console.Write("fiveteen");
                }
                if (ones == 6)
                {
                    Console.Write("sixteen");
                }
                if (ones == 7)
                {
                    Console.Write("seventeen");
                }
                if (ones == 8)
                {
                    Console.Write("eighteen");
                }
                if (ones == 9)
                {
                    Console.Write("nineteen");
                }






            }
        }

    }
}
