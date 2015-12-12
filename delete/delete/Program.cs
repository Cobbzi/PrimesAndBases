using System;

namespace delete
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 13, 64, 15, 17, 88 };
            int[] arr2 = new int[] { 23, 14, 53, 17, 80 };
            Console.WriteLine(Kata.Swap("abcdDEFG"));
            Console.Read();
        }
    }

    public class Kata
    {
        public static string Swap(string str)
        {
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                    char.ToLower(c);
                else
                    char.ToUpper(c);
            }
            return str;
        }
    }
}
