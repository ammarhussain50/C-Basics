using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "John Doe";
            String name2 = "Ammar Doe";
            Char character = 'A';
            Console.WriteLine($"name is {name}");
            Console.WriteLine(character);
            string number = "12345";
            int num = Convert.ToInt32(number);
            Console.WriteLine($"num is {num}");
        }
    }
}
