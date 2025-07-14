using System.Runtime.InteropServices;

namespace functions_with_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(add(5,5));
            //int num = readint("number");
            //Console.WriteLine(num);

            //int angle = readint("angle");
            //Console.WriteLine(angle);

            int firstnum = readint("first number");
            int secondnum = readint("second number");
            int result = add(firstnum, secondnum);
            Console.WriteLine($"The sum of {firstnum} and {secondnum} is {result}");

            string name = readstring("Enter your name: ");
            
            int age = readint("Enter your age: ");
            Console.WriteLine(detailname(name, age));

            Console.WriteLine(adding(5));
            stri();


        }

        static string detailname(string name, int age)
        {
            return "my name is  " + name + " and age is " + age; 
        }

        /// optional parameter   ////
        static int adding(int a , [Optional] int b)
        {
            Console.WriteLine($" the value of b is {b}");
            return a + b;
        }
        static void stri(string b = default)
        {
            Console.WriteLine($"my name is {b}");
        }



        static string readstring(string message)
        {
            Console.Write($"{message}");
            return Console.ReadLine();
        }

        static int readint(string message)
        {
            Console.Write($"{message}");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int add(int a,int b)
        {
            return a + b;
        }
    }
}
