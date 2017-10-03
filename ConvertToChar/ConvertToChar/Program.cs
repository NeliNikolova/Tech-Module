using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToChar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            for ( int i = numberOne;  i <=numberTwo;  i++)
            {
                char m = Convert.ToChar(i);
                Console.Write("{0} ", m);
            }
            
        }
    }
}
