namespace pushing_even_odd_in_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else if (i % 2 == 1)
                {
                    odd.Add(i);
                }
                
            }
            Console.Write("Even: ");
            foreach (int num in even)
            {
                Console.Write( num);
            }
            
            Console.WriteLine();
            Console.Write("odd: ");

            foreach (int num in odd)
            {
                Console.Write(num);
            }   
        }
    }
}
