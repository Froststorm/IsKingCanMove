using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class kingCheckcs
    {
        public static string isKingCanMove(int x1=1, int y1=1, int x2=1, int y2=1)
        {
            //int x1 = 1; //Convert.ToInt32(Console.ReadLine());

            //int y1 = 1; //Convert.ToInt32(Console.ReadLine());

            //int x2 = 2; //Convert.ToInt32(Console.ReadLine());

            //int y2 = 2; // Convert.ToInt32(Console.ReadLine());
            int one = Math.Abs(x1 - x2);
            int two = Math.Abs(y1 - y2);
            Console.WriteLine($"{one} {two}");


            bool isFirstOne = Math.Abs(x1 - x2) == 1;
            bool isSecondOne = Math.Abs(y1 - y2) == 1;
            bool result3 = isFirstOne && isSecondOne;
            bool result4 = (x1 == x2) && (y1 == y2);
            Console.WriteLine($"res3 - {result3}, res4 - {result4}");

            string yesNo = result4 || result3 ? "YES" : "NO";

            return yesNo;
        }
    }
}
