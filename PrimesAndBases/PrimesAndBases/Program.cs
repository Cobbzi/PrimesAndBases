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
                Console.WriteLine("║    Primes and Bases    ║");
                Console.WriteLine("║                        ║");
                Console.WriteLine("║                        ║");
                Console.WriteLine("║    [1] Begin           ║");
                Console.WriteLine("║    [2] How it works    ║");
                Console.WriteLine("║    [0] Exit            ║");
                Console.WriteLine("║                        ║");
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
                        Console.Clear();
                        Console.WriteLine("Enter a word, with letters ranging from 'A' to 'Z'.");
                        new Program().CalculateWords(Console.ReadLine());
                        break;
                    case 2:
                        new Program().DisplayTutorial();
                        break;
                }

            } while (selection != 0);
        }

        // Looks bad but it's fast!
        private void InitiateletterLibrary()
        {
            letterLibrary.Clear();
            letterLibrary.Add(new Letter("a", 1));
            letterLibrary.Add(new Letter("b", 2));
            letterLibrary.Add(new Letter("c", 3));
            letterLibrary.Add(new Letter("d", 4));
            letterLibrary.Add(new Letter("e", 5));
            letterLibrary.Add(new Letter("f", 6));
            letterLibrary.Add(new Letter("g", 7));
            letterLibrary.Add(new Letter("h", 8));
            letterLibrary.Add(new Letter("i", 9));
            letterLibrary.Add(new Letter("j", 10));
            letterLibrary.Add(new Letter("k", 11));
            letterLibrary.Add(new Letter("l", 12));
            letterLibrary.Add(new Letter("m", 13));
            letterLibrary.Add(new Letter("n", 14));
            letterLibrary.Add(new Letter("o", 15));
            letterLibrary.Add(new Letter("p", 16));
            letterLibrary.Add(new Letter("q", 17));
            letterLibrary.Add(new Letter("r", 18));
            letterLibrary.Add(new Letter("s", 18));
            letterLibrary.Add(new Letter("t", 19));
            letterLibrary.Add(new Letter("v", 3));
            letterLibrary.Add(new Letter("w", 4));
        }
        
        // We calculate the word by "switching" the input and checking each letter in the string
        // Also very fast since it's a switch function
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
                    case 'e':
                        calcList.Add(5);
                        break;
                    case 'f':
                        calcList.Add(6);
                        break;
                    case 'g':
                        calcList.Add(7);
                        break;
                    case 'h':
                        calcList.Add(8);
                        break;
                    case 'i':
                        calcList.Add(9);
                        break;
                    case 'j':
                        calcList.Add(10);
                        break;
                    case 'k':
                        calcList.Add(11);
                        break;
                    case 'l':
                        calcList.Add(12);
                        break;
                    case 'm':
                        calcList.Add(13);
                        break;
                    case 'n':
                        calcList.Add(14);
                        break;
                    case 'o':
                        calcList.Add(15);
                        break;
                    case 'p':
                        calcList.Add(16);
                        break;
                    case 'q':
                        calcList.Add(17);
                        break;
                    case 'r':
                        calcList.Add(18);
                        break;
                    case 's':
                        calcList.Add(19);
                        break;
                    case 't':
                        calcList.Add(20);
                        break;
                    case 'v':
                        calcList.Add(21);
                        break;
                    case 'w':
                        calcList.Add(22);
                        break;
                }
            }

            CalculateFinal();
        }

        // We caclulate the final sum
        private void CalculateFinal()
        {
            try
            {
                long finalValue = long.Parse(Math.Pow(Primes[0], calcList[0]).ToString());
                for (int i = 1; i < calcList.Count; i++)
                {
                    finalValue *= long.Parse(Math.Pow(Primes[i], calcList[i]).ToString());
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
            Console.Clear();
            Console.WriteLine("Okay so as you've probably figured out, this program is calculating a value from words. What you didn't is that it's calculating the value of the word by the use of fractions, prime numbers and letter values");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The first thing we need to do is get input from the user. We then match all the letters in the string(input) and if we have a letter with a value that matches the one in the string, we add a value to the 'calculation list'.");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("We then proceed to the final calculation by first  calculating the first values from the list since we'll later on multiply the base value with the rest of the values. Illustration, 'value *= first added prime raised to the power of the first added letter value'");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("By now you will probably have an idea of how it works and why it works. Below i'll just add the algortihm for the calculation, which you'll probably understand!\n");
            Console.WriteLine("= Super sexy algortihm =");
            Console.WriteLine("[1]\tGet input");
            Console.WriteLine("[2]\tMatch input with letter list");
            Console.WriteLine("[3]\tCalculate first value with primes as base and letters as potent");
            Console.WriteLine("[4]\tCalculate final by multiplying every value in the lists");
            Console.WriteLine("[5]\t????");
            Console.WriteLine("[6]\tPROFIT!!!");
            Console.WriteLine("= Super sexy algortihm =");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadKey();
        }
    }
}
