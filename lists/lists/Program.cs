namespace lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            //{ 1,2,3,4,5,6,7,8,9,10 };

            ///// list me length ka msla ni hota 
            List<int> numbersList = new List<int>();
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number: ");
                
                numbersList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            ///// length ni count hota hay
            foreach(int number in numbersList)
            {
                Console.Write(number);
            }
            
        }
    }
}
