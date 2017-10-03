using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
           
                string input = Console.ReadLine();

                int value;

                if (int.TryParse(input, out value))
                {
                    Console.WriteLine("digit");
                }
                else if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }

            }
        }
    }


