namespace Functions
{
    internal class Program
    {
        /// cannot acess this variable outside the class
        static string name = "Function";

        static void Main(string[] args)
        {
            
            Console.Title = "Functions";
            Console.WriteLine(name);
            welcome();
            Console.WriteLine();
            /// easily acess static methods outside class
            test.something();

            // we have to make new instance of the class to access non-static methods
            test tests = new test();
            tests.somethingElse();
        }
        static void welcome() {
            Console.WriteLine("welcome");
            Console.WriteLine(name);
            Console.WriteLine(getName());
            Console.WriteLine(getNumber());
            int [] arr2 = createarray();
            foreach (var item in arr2)
            {
                Console.Write($"{item} ");
            }
        }
        static string getName()
        {
            return "ammar";
        }
        static int[] createarray()
        {
            
            return new int[5] {1,2,3,4,5};
        }
        static int getNumber()
        {
            return 5;
        }
    }


    class test
    {
        public static void something()
        {
            Console.WriteLine("something");

        }
        public void somethingElse()
        {
            Console.WriteLine("something else");
        }
    }
}
