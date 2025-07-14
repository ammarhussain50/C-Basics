namespace try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;
            while (looping)
            {
                try
                {
                    Console.WriteLine("enter number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);
                    looping = false;
                }
                //catch (OverflowException e)
                //{
                //    Console.WriteLine($"{e.Message}number is too big or too small");
                //}
                //catch (ArgumentNullException e)
                //{
                //    Console.WriteLine($"{e.Message} you didn't enter anything");
                //}
                //catch (FormatException e)
                //{
                //    Console.WriteLine($"{e.Message}please  enter only number");
                //}

                //  dont need all type of catches  //
                catch (Exception e)
                {
                    Console.WriteLine($" {e.Message} ");
                }
                

            }
            Console.WriteLine("good bye");


        }
    }
}
