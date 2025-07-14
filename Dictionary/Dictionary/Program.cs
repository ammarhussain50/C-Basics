using System.Collections;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<int,string> names = new Dictionary<int, string>
            {
                /// key value pair
                {23,"dadd" },
                {12312,"asfaas" },
                {123124124,"asfsadf" }
            };

            names.Add(1,"hello");
            names.Add(2, "ammar");

            for (int i = 0; i < names.Count; i++)
            {
                // Accessing the key-value pair using the indexer
                Console.WriteLine($"Key: {names.Keys.ElementAt(i)}, Value: {names.Values.ElementAt(i)}");
            }

            foreach (KeyValuePair<int, string> items in names)
            {
                // Accessing the key-value pair using KeyValuePair
                Console.WriteLine($"Key: {items.Key}, Value : {items.Value}");
            }

            Dictionary<string, string> names2 = new Dictionary<string, string>
            {
                {"abc","hello" },
                {"def", "world" },
                {"ghi", "!" }
            };
            //////// removing value from dictionary
            names2.Remove("ghi");
            foreach (KeyValuePair<string, string> item in names2)
            {
                // Accessing the key-value pair using KeyValuePair
                Console.WriteLine($"Key: {item.Key}, Value : {item.Value}");
            }

            /////////   changing value in dictionary
            names2["abc"] = "hellooooo";
           


            for (int i=0; i < names2.Count; i++)
            {
                if (names2.TryGetValue("abc", out string value))
                {
                    // Accessing the value using TryGetValue
                    Console.WriteLine($"Key: abc, Value: {value}");
                    break;
                }
                else
                {
                    Console.WriteLine("Key not found.");
                }
            }


            /// find key and remove it 
            if (names2.ContainsKey("def"))
            {
                names2.Remove("def");
            }
            else
            {
                Console.WriteLine("Key 'def' does not exist in the dictionary.");
            }


        }
    }
}
