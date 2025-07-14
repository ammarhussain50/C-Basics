using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("enter your name ");  // enter input on same line
            //string name = Console.ReadLine();  // read input from user
            Console.Write("enter age ");
            string age  = Console.ReadLine();
            int age2 = Convert.ToInt32(age);
            //Console.WriteLine();  // for line gap
            //Console.Write("Hello " + name + " and age is "+ age2);  // output greeting

            /////////////   if else     ///////
            if (age2 >= 18 && age2 <= 25)
            {
                Console.WriteLine("age is under 18");
            }
            else if(age2 >= 25)
            {
                Console.WriteLine("age is greater than 18");
            }

            Console.Write("enter number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1);

            Console.Write("enter number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number2);

            int answer = number1 * number2;
            Console.Write("value of " +number1+ " X "+ number2+" : ");

            int actualanswer = Convert.ToInt32(Console.ReadLine());
            if (actualanswer == answer)
            {
                Console.WriteLine("Correct answer");
            }
          
            else if (actualanswer != answer)
            {
                Console.WriteLine("Your answer is wrong");
            }


        }
    }
}
