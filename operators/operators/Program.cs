using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float age = 23;
            age /= 10;
            Console.WriteLine(age);

            string name = "abc ";
            name += "ammar";
            Console.WriteLine(name);
            int i = 0;
            Console.WriteLine(i++);
            Console.WriteLine(i);
            int a = 10;
            int b = 3;
            float c = (float)  a/ b;
            Console.WriteLine("{0:F2}", c);  // Output: 3.33
            var age2 = 20;
            Console.WriteLine(age2);
            var bignumber = 23145688l;
            Console.WriteLine(bignumber);
            var decimalNumber = 123.456m;
            Console.WriteLine(decimalNumber);
            var floa = 123.456f;
            Console.WriteLine(floa);
            var doubl = 123.456D;
            Console.WriteLine(doubl);
            var stri = "Hello World";
            Console.WriteLine(stri);
            var chara = 'A';
            Console.WriteLine(chara);
            const double vat = 20;
            int balance  = 1000;
            Console.WriteLine(balance * (vat/100));





        }
    }
}
