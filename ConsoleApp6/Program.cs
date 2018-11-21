using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(kingCheckcs.isKingCanMove(2,2,3,3));
            Console.WriteLine(kingCheckcs.isKingCanMove(3,3,1,1));
            Console.WriteLine(kingCheckcs.isKingCanMove(1,1,2,3));
            Console.WriteLine(kingCheckcs.isKingCanMove(1,1,3,3));
            Console.ReadKey();

        }
    }
}
