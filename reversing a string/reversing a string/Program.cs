namespace reversing_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter a string to reverse:");
            string input = Console.ReadLine();
            
            for(int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
