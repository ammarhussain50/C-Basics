using System.Diagnostics.Metrics;

namespace Array_of_multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;
            int[] multiples = new int[length];
            int Counter = 0;
            for (int i = 1; i <= multiples.Length; i++, Counter++)
            {
                multiples[Counter] = num * i;
                

            }

            foreach (var multiple in multiples)
            {
                Console.Write($" {multiple}");
            }
        }
    }
}
