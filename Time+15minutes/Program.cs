using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min = min + 15;
            if (min > 59)
            {
                hour = hour + 1;
                min = min - 60;
            }
            if (hour > 23)
            {
                hour = hour - 24;
            }
            if (min<10)
            {
                Console.WriteLine(hour + ":" + "0" + min);
            }
            else if (min>9)
            {
                Console.WriteLine(hour + ":" + min);
            }
            
        }
    }
}
