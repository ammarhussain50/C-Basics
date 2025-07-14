namespace Caculate_Area_of_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = readint("enter a width");
           int height = readint("enter a height");
           double result = calarea(width, height);

            Console.WriteLine($" the area is {result} " );

        }
        static double calarea(int x, int y) { 
        return (x * y) / 2D;
        }
        static int readint(string s) {
            Console.WriteLine(s);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
