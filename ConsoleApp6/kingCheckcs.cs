using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    public class kingCheckcs
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static void isKingCanMove()
        {
            while (true)
            {
                string numstring = Console.ReadLine();
                
                int firstHalf = int.Parse(numstring.Substring(0,numstring.Length / 2));
                string secString = numstring.Substring(numstring.Length / 2, numstring.Length - numstring.Length / 2);
                int secHalf = int.Parse(ReverseString(secString));


                Console.WriteLine(firstHalf == secHalf ? "YES":"NO");

            }
           
        }
    }
}
