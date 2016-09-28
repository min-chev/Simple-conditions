using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double result = 0;
            if (type == "square")
            {
                result = a * a;
            }
            else if (type == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                result = a * b;
            }
            else if (type == "circle")
            {
                result = Math.PI *a * a;
            }
            else if (type == "triangle")
            {
                double b = double.Parse(Console.ReadLine());
                result = (a * b) / 2;
            }
            Console.WriteLine(Math.Round(result, 3));

        }
    }
}
