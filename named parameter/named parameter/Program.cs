namespace named_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameinpt = "ammar";
            int ageinpt = 10;
            int countinpt = 0;

            printdetail(age:ageinpt, name:nameinpt, count:countinpt);

            int num = 10;
            test(out num);
            Console.WriteLine(num);


        }
        static void test(out int num) {
             num = 1000;
        }

        static void printdetail(string name, int age, int count) {
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"count is {count}");

        }
    }
}
