using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter day");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 0:
                    Console.WriteLine("mon");
                    break;
                case 1:
                    Console.WriteLine("tue")
                    ; break;
                case 2:
                    Console.WriteLine("wed")
                    ; break;
                case 3:
                    Console.WriteLine("thursday")
                    ; break;
                case 4:
                    Console.WriteLine("fri")
                        ; break;
                case 5:
                    Console.WriteLine("sat")
                        ; break;
                case 6:
                    Console.WriteLine("sun")
                        ; break;
                default:
                    Console.WriteLine("error");
                    break;


            }
        }
    }
}

