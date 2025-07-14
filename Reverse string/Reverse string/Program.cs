namespace Reverse_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Enter a string to reverse:");
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }


            Console.WriteLine();
            string password = "PAssword123";
            Console.WriteLine(password.ToLower());
            string password2 = "password123";
            Console.WriteLine(password2.ToUpper());




        }
    }
}
