using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOrChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringFirst = Console.ReadLine();
            char charFirst = char.Parse(Console.ReadLine());
            char charSecond = char.Parse(Console.ReadLine());
            char charThird = char.Parse(Console.ReadLine());
            string stringSecond = Console.ReadLine();
            Console.WriteLine(stringFirst);
            Console.WriteLine(charFirst);
            Console.WriteLine(charSecond);
            Console.WriteLine(charThird);
            Console.WriteLine(stringSecond);
        }
    }
}
