using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_operator_ternary_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 10;
            Console.WriteLine(age >= 18 ? "Adult" : "Minor");

            double value = 100D / 12.22D;
            Console.WriteLine(value);

            Console.WriteLine(string.Format("$ {0:0.0000}",value));  // bad way //
            Console.WriteLine(value.ToString("c0"));
            Console.WriteLine(value.ToString("c6"));  // best way //
            Console.WriteLine(value.ToString("c4",CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(value.ToString("c4", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(value.ToString("c4", CultureInfo.CreateSpecificCulture("en-AU")));
        }

    }
}
