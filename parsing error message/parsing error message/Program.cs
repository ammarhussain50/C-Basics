using System;

namespace parsing_error_message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool success = false;
            //try
            //{
            //    Console.WriteLine("enter a number");
            //    int nun = Convert.ToInt32(Console.ReadLine());
            //    success = true;

            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine("An unexpected error occurred.");
            //    Console.WriteLine($"Details: {ex.Message}");
            //}
            //Console.WriteLine(success? "yey hooo":"oo no nonononon");


            Console.WriteLine("enter number");
            if (tryparse(Console.ReadLine(), out int number))
            {
                Console.WriteLine($"You entered: {number}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");

            }

            static bool tryparse(string inp, out int result)
            {

                result = -1;
                try
                {

                    result = Convert.ToInt32(inp);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                  

                }


            }
        }
    }
}
