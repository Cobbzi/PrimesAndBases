using System;
using System.Collections.Generic;
using System.Numerics;

namespace PrimesAndBases
{
    class Program
    {
        uint[] Primes = new uint[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997 }; // The first 1000 prime numbers
        List<int> calcList = new List<int>(); // Calculation list, no need for large data types
        List<Letter> letterLibrary = new List<Letter>(); // Library of letters!
        static void Main(string[] args)
        {
            // Since this method is static, we need to call a new class and call it from there.
            new Program().PopulateList();
            new Program().Selection();
        }

        // Pretty self-explainatory content, no need for comments
        // uint's because of the selections never needing to be negative values
        private void Selection()
        {
            uint selection = uint.MaxValue;
            do
            {
                selection = uint.MaxValue;
                calcList.Clear();

                Console.Clear();

                // Super sexy style!
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
                    selection = uint.Parse(Console.ReadLine());
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
                        Console.WriteLine("Enter a word, with letters ranging from 'A' to 'Z'.\n(All words might not work, there are some data type limitations)");

                        new Program().CalculateWords(Console.ReadLine());
                        break;
                    case 2:
                        new Program().DisplayTutorial();
                        break;
                    default:
                        Console.WriteLine("Input not recognized.");
                        break;
                }

            } while (selection != 0);
        }

        private void PopulateList()
        {
            char[] character = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray(); // Make every letter lowercase and put them in an array
            for (int i = 0; i < character.Length; i++) // Loop through them all
            {
                letterLibrary.Add(new Letter(character[i], i + 1)); // Add new letter to the library

                // Debug
                Console.WriteLine("Added {0} with value {1}", character[i], i + 1);
                Console.WriteLine(letterLibrary[i].name);
            }
        }
        private void CalculateWords(string input)
        {
            input = input.ToLower(); // make it all lowercase
            // Ugly but fast
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
                    case 'u':
                        calcList.Add(21);
                        break;
                    case 'v':
                        calcList.Add(22);
                        break;
                    case 'w':
                        calcList.Add(23);
                        break;
                    case 'x':
                        calcList.Add(24);
                        break;
                    case 'y':
                        calcList.Add(25);
                        break;
                    case 'z':
                        calcList.Add(26);
                        break;
                }
            }

            CalculateFinal();
        }

        private void CalculateFinal()
        {
            try
            {
                Console.Clear();

                // BigInteger is the largest data type which isn't a double precision data type
                // Double could've been used but we don't need the decimal precision but rather bigger integers
                BigInteger finalValue = 1; // We set it to 1 because else we would be multiplying every result with 0

                for (int i = 0; i < calcList.Count; i++)
                {
                    finalValue *= BigInteger.Parse(Math.Pow(Primes[i], calcList[i]).ToString()); // First prime ^ first letter and so on...

                    // Just making sure we don't add a * sign in the beginning
                    // Note: I was lazy so I didn't use a modulo operation or whatever it's called (lol)
                    if (i < calcList.Count && i > 0)
                        Console.Write($" * ({Primes[i]}^{calcList[i]})"); // Look on the other output for explanation
                    else
                        Console.Write($"({Primes[i]}^{calcList[i]})"); // Looks a little messy, but it's more efficient this way. It reads, ( Primes[i] ^ calcList[i] ) - easier now?
                }

                Console.Write($" = {finalValue}"); // Printing the final value.
                // Also, a little side note as you can see on the line above, I'm using one of the new features in C# 6.0! Thee string formatting shortener '$'!

                Console.WriteLine("\nPress enter to continue");
                Console.ReadKey();
            }
            catch (Exception ex) // Print the exception that occured (in the case of it actually happening)
            {
                Console.WriteLine("\n" + ex.Message + "\nThe calculated value was likely to big for any datatype(yes, even BigInteger).\nTry another word!\n\nPress enter to continue...");
                Console.ReadLine();
            }
        }

        // I won't dare to comment on this haha
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
            Console.WriteLine("We then proceed to the final calculation by setting the final value = 1, since we'll later on multiply it (avoid multiplying with 0). We then take the first prime in the list and use it as a base, we then raise the base value to the power of the first letter's value in the list. We then multiply all these values together, which can and will result in very large numbers (that's why I put a warning in the input section). To clarify, prime[n] ^ letter[n] where 'n' is the position in the list.");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("By now you will probably have an idea of how it works and why it works. Below i'll just add the algortihm for the calculation, which you'll probably understand!\n");
            Console.WriteLine("= Super sexy algortihm =");
            Console.WriteLine("[1]\tGet input");
            Console.WriteLine("[2]\tMatch input with letter list");
            Console.WriteLine("[3]\tCalculate value with first prime as base and raise it to the first letter's value");
            Console.WriteLine("[4]\tCalculate final by multiplying every value just calculated");
            Console.WriteLine("[5]\t????");
            Console.WriteLine("[6]\tPROFIT!!!");
            Console.WriteLine("= Super sexy algortihm =");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadKey();
        }
    }
}
