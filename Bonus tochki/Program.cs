using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_tochki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter points : ");
            decimal points = int.Parse(Console.ReadLine());
            Decimal bonuspoints = new int();
            if (points <= 100)
            {
                bonuspoints = 5;
            }
            else if (points > 100 && points <= 1000)
            {
                bonuspoints = points * 20/100;
            }
            else if (points > 1000)
            {
                bonuspoints = points * 10/100;
            }

            if (points % 2 ==0)
            {
                bonuspoints = bonuspoints + 1;
            }
            else if (points % 5 == 0)
            {
                bonuspoints = bonuspoints + 2;
            }

            Console.Write("Bonus score : ");
            Console.WriteLine(bonuspoints);
            Console.Write("Total score : ");
            Console.WriteLine(bonuspoints+points);
        }
    }
}
