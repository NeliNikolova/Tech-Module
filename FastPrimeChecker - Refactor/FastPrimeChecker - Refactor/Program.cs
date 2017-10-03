using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <=number; i++)
            {
                bool isNotTrue = true;
                for (int n = 2; n <= Math.Sqrt(i); n++)
                {
                    if(i % n == 0)
                    {
                        isNotTrue = false;
                        break;
                    }
                    
                }
                Console.WriteLine($"{i} -> {isNotTrue}");
            }

        }
    }
}


