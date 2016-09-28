using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            //1000 millimeters(mm)
            //100 centimeters(cm)
            //0.000621371192 miles(mi)
            //39.3700787 inches(in)
            //0.001 kilometers(km)
            // 3.2808399  feet(ft)
            //1.0936133 yards(yd)

            decimal amount = decimal.Parse(Console.ReadLine());
            var unitsfrom = Console.ReadLine();
            var unitsto = Console.ReadLine();
            if (unitsfrom == "m")
            {
                amount = amount/1m;
            }
            if (unitsfrom == "mm")
            {
                amount = amount / 1000m;
            }
            if (unitsfrom == "cm")
            {
                amount = amount / 100m;
            }
            if (unitsfrom == "mi")
            {
                amount = amount / 0.000621371192m;
            }
            if (unitsfrom == "in")
            {
                amount = amount / 39.3700787m;
            }
            if (unitsfrom == "km")
            {
                amount = amount / 0.001m;
            }
            if (unitsfrom == "ft")
            {
                amount = amount / 3.2808399m;
            }
            if (unitsfrom == "yd")
            {
                amount = amount / 1.0936133m;
            }

            //-----------------------------------
            if (unitsto == "m")
            {
                amount = amount * 1m;
            }
            if (unitsto == "mm")
            {
                amount = amount * 1000;
                    
               }
            if (unitsto == "cm")
            {
                amount = amount * 100m;
            }
            if (unitsto == "mi")
            {
                amount = amount * 0.000621371192m;
            }
            if (unitsto == "in")
            {
                amount = amount * 39.3700787m;
            }
            if (unitsto == "km")
            {
                amount = amount * 0.001m;
            }
            if (unitsto == "ft")
            {
                amount = amount * 3.2808399m; 
            }
            if (unitsto == "yd")
            {
                amount = amount * 1.0936133m;  
            }

            Console.WriteLine(amount);
        }
    }
}
