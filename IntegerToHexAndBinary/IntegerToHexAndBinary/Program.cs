using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string numberConvertToHexa = Convert.ToString(num,16).ToUpper();
            string numberConvertToBinary = Convert.ToString(num, 2);

            Console.WriteLine(numberConvertToHexa);
            Console.WriteLine(numberConvertToBinary);
        }
    }
}