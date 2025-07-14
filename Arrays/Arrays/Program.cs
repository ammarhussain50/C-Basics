namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            //int[] numbers = { num1, num2, num3,8 };
            //int [] numbers = new int[5];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}



            ////for (int i = 0; i < numbers.Length; i++)
            ////{
            ////    Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            ////}

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine($"Number: {number}");
            //}

            //int[] angles = new int[3];
            //for (int i = 0; i < angles.Length; i++)
            //{
            //    Console.Write($"Enter angle {i + 1}: ");
            //    angles[i] = Convert.ToInt32(Console.ReadLine());
            //}
            ///// we can not initialize new varible insibe loop ///
            //int anglesum = 0;
            //foreach (int angle in angles)
            //{
            //     anglesum += angle;
            //}

            //Console.WriteLine(anglesum==180? "line" : "notline");


            int[] ints = new int[] { 10,8,2,3,1,5};
            //Array.Sort(ints); // Sorts the array in ascending order
            //Array.Reverse(ints); // Reverses the order of the elements in the array
            foreach (int i in ints)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            //// reverse the array and store in another array
            int[] sort = new int[ints.Length];
            int x = 0;
            for (int i = ints.Length - 1; i >= 0; i--)
            {
                sort[x] = ints[i];
                x++;
            }

            foreach (int i in sort)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            //////   clearing the array from 0 to length 
            Array.Clear(ints, 0, ints.Length); // Clears the entire array



            /////////////   index of  /////////
            int[] arr = {2,4,5,6,7,89,8,9,0,5,1,2,3,4};
            Console.WriteLine("enter num which y want:");
            int search = Convert.ToInt32(Console.ReadLine());
            int position = Array.IndexOf(arr, search,4,10); /// starting index is 4
            if (position > -1)
            {
                Console.WriteLine($"The number {search} is found at index {position}.");
            }
            else
            {
                Console.WriteLine($"The number {search} is not found in the array.");
            }

            ////// 4 se 9 tk chlega 10 se aik kaam ////
            
        }
    }
}
