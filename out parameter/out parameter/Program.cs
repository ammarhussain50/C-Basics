namespace out_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // example 1  ////
            var nameList = new List<string> { "Ali", "Ammar", "Sara" };
            if (FindName("ammar", nameList, out int idx))
            {
                Console.WriteLine($"Found at index: {idx}");
            }
            else
            {
                Console.WriteLine("Name not found.");
            }

            /// example 2  ////
            int q, r;
            Divide(10, 3, out q, out r);
            Console.WriteLine($"Quotient: {q}, Remainder: {r}");


        }



        // example 1  /////////
        static bool FindName(string search, List<string> names, out int index)
        {
            index = -1;
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].ToLower() == search.ToLower())
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }

        // example 2  ////
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }




    }
}
