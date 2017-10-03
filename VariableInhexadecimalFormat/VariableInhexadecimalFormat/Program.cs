using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInhexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();
            int decimalNum= Convert.ToInt32(hexadecimal, 16);
            Console.WriteLine(decimalNum);
        }
    }
}
