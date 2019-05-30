using System;

public class MainClass
{
    public static void Main()
    {

        //int firstHalf = int.Parse(numstring.Substring(0, numstring.Length / 2));
        //string secString = numstring.Substring(numstring.Length / 2, numstring.Length - numstring.Length / 2);
        //int secHalf = int.Parse(ReverseString(secString));
        while (true)
        {
            string numstring = Console.ReadLine();
            numstring = numstring.Length < 4  ? numstring + "0" : numstring;
            int lenght = numstring.Length;
            Console.WriteLine($"{lenght}");

            int firstHalf = int.Parse(numstring.Substring(0, lenght));
            string secString = numstring.Substring(0,lenght);
            Console.WriteLine(secString);
            int secHalf = int.Parse(ReverseString(secString));

            Console.WriteLine($"{firstHalf} {secHalf}");

            Console.WriteLine(firstHalf == secHalf ? "YES" : "NO"); 
        }

        string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }



    }
}