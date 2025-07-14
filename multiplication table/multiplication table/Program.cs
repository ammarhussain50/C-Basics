using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());  // You can change this number to any other

            Console.WriteLine("Multiplication Table of " + number + ":");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }


            string Path = @"c:\temp\multiplication\c# course" + "\n newline";
            Console.WriteLine(Path);
            string name = @"hello ""something"" ";
            Console.WriteLine(name);

            
        }
    }
}
