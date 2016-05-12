using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace templateAppName
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string template;
            string output;
            string result;
            string var;
            string var_value;
            Console.WriteLine("Please write your message. Use % where variables will be used.");
            template = Console.ReadLine();

            Console.WriteLine("What is the variable name?");
            var = Console.ReadLine();

            Console.WriteLine("What is the value?");
            var_value = Console.ReadLine();

            dictionary.Add(var, var_value);

            output = template;
            result = output.Replace("%", var_value);
            Console.WriteLine(result);

            Console.WriteLine("testing shit...");

            string myvar = dictionary[var];
            Console.WriteLine(myvar);
            Console.ReadLine();

        }
    }
}
