using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seconds
{
    class Program
    {
        private static object port;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 Race Times in Seconds : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int seconds = a + b + c;
            int seconds1 = seconds - 60;
            int seconds2 = seconds - 120;
            if (seconds >= 0 && seconds <= 59)
            {
                if (seconds > 9)
                {
                    Console.WriteLine("0:{0}", seconds);
                }
                else if (seconds < 10)
                {
                    Console.WriteLine("0:0{0}", seconds);
                }
            }
            if (seconds >= 60 && seconds <= 119)
            {
                if (seconds1 > 9)
                {
                    Console.WriteLine("1:{0}", seconds1);
                }
                else if (seconds1 < 10)
                {
                    Console.WriteLine("1:0{0}", seconds1);
                }
                
            }
            if (seconds >= 120)
            {
                if (seconds2 > 9)
                {
                    Console.WriteLine("2:{0}", seconds2);
                }
                else if (seconds2 < 10)
                {
                    Console.WriteLine("2:0{0}", seconds2);
                }


            }

        }
    }
}
