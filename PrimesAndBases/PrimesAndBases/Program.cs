using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesAndBases
{
    class Program
    {
        int[] Primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997 };
        List<Letter> letterLibrary = new List<Letter>();
        List<int> calcList = new List<int>();
        static void Main(string[] args)
        {
            new Program().InitiateletterLibrary();
            int selection = int.MaxValue;
            do
            {
                selection = int.MaxValue;
                Console.Clear();
                Console.WriteLine("╔════════════════════════╗ ");
                Console.WriteLine("║                        ║");
                Console.WriteLine("║    [1] Begin           ║");
                Console.WriteLine("║    [2] How it works    ║");
                Console.WriteLine("║    [0] Exit            ║");
                Console.WriteLine("║                        ║");
                Console.WriteLine("╚════════════════════════╝");

                try
                {
                    selection = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("\nPress enter to continue");
                    Console.ReadLine();
                }

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Enter a word ranging from 'a' to 'd'.");
                        new Program().CalculateWords(Console.ReadLine());
                        break;
                    case 2:
                        new Program().DisplayTutorial();
                        break;
                }

            } while (selection != 0);
        }

        private void InitiateletterLibrary()
        {
            letterLibrary.Add(new Letter("a", 1));
            letterLibrary.Add(new Letter("b", 2));
            letterLibrary.Add(new Letter("c", 3));
            letterLibrary.Add(new Letter("d", 4));
        }

        private void CalculateWords(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                        calcList.Add(1);
                        break;
                    case 'b':
                        calcList.Add(2);
                        break;
                    case 'c':
                        calcList.Add(3);
                        break;
                    case 'd':
                        calcList.Add(4);
                        break;
                }
            }

            CalculateFinal();
        }

        private void CalculateFinal()
        {
            try
            {
                double finalValue = Math.Pow(Primes[0], calcList[0]);
                for (int i = 1; i < calcList.Count; i++)
                {
                    finalValue *= Math.Pow(Primes[i], calcList[i]);
                }
                Console.WriteLine("Calculated value: {0}", finalValue);
                Console.WriteLine("\nPress enter to continue");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void DisplayTutorial()
        {

        }
    }
}
