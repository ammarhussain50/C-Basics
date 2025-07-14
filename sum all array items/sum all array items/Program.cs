namespace sum_all_array_items
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] number = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = sumofnumbers(number);
            Console.WriteLine("Sum of array elements: " + total);
        }

        static int sumofnumbers(int[] numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                count += number;
            }
            return count;
        }
    }
}