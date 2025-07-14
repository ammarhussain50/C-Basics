namespace Ref_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  example 1  //
            int number = 5;
            DoubleNumber(ref number);
            Console.WriteLine("Doubled: " + number);  // Output: 10

            /// example 2 ///
            int x = 10, y = 20;
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");  // Output: x = 20, y = 10

            // example 3  //
            int[] numbers = { 1, 2, 3 };
            UpdateFirstItem(ref  numbers);
            Console.WriteLine(numbers[0]);  // Output: 100

        }


        //  example 1  //
        static void DoubleNumber(ref int num)
        {
            num = num * 2;
        }

        // example 2   ////
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // example 3  //
        static void UpdateFirstItem(ref int[] arr)
        {
            arr[0] = 100;
        }
    }
}
