namespace string_formating
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /////   style for writing strings   /////
            //string Path = @"c:\temp\multiplication\c# course" + "\n newline";
            //Console.WriteLine(Path);
            //string name = @"hello ""something"" ";
            //Console.WriteLine(name);

            //string name2 = "Ammar" + "\nHussain";
            //Console.WriteLine(name2);

            //string firstname = "ammar";
            //int age = 22;
            //Console.WriteLine("your name is {0} and age is {1}",firstname,age);

            //string test = string.Concat("your name is ", "ammar") ;
            //Console.WriteLine(test);


            /////////////  empty strings  /////////// 
            //Console.WriteLine("enter string");
            //string input = Console.ReadLine();
            //if (input == string.Empty)
            //{
            //    Console.WriteLine("you entered empty string");
            //}
            //else
            //{
            //    Console.WriteLine("you entered: " + input);
            //}


            //////////  string equality  ////////
            //string str1 = "hello";
            //string str2 = "hello";
            //if (str1.Equals(str2))
            //{
            //    Console.WriteLine("strings are equal");
            //}
            //else
            //{
            //    Console.WriteLine("strings are not equal");
            //}


            string message = "Hello, World!";
            for(int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(100); // Sleep for 1 second to see each character printed one by one

            }
            Console.WriteLine();
            Console.WriteLine(message.Contains("o"));

            ////// is null or empty //////
            string check = null;
            if (string.IsNullOrEmpty(check))
            {
                Console.WriteLine("check is null or empty");
            }
            else
            {
                Console.WriteLine("check is not null or empty");
            }

        }
    }
}

