using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class kingCheckcs
    {
        public static string isKingCanMove(int x1 = 1, int y1 = 1, int x2 = 1, int y2 = 1)
        {
            //int x1 = 1; //Convert.ToInt32(Console.ReadLine());

            //int y1 = 1; //Convert.ToInt32(Console.ReadLine());

            //int x2 = 2; //Convert.ToInt32(Console.ReadLine());

            //int y2 = 2; // Convert.ToInt32(Console.ReadLine());


            string yesNo;
            int one = Math.Abs(x1 - x2);
            int two = Math.Abs(y1 - y2);

            if (one == 2 && two == 1)
            {
                yesNo = "YES";

            }
            else if (one == 1 && two == 2)
            {
                yesNo = "YES";
            }
            else
            {
                yesNo = "NO";

            }


            Console.WriteLine(yesNo);
        }
    }
}
