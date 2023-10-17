using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_and_character_manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(check("FizzBuzz"));
            Console.WriteLine(check("Fizz"));
            Console.WriteLine(check("Buzz"));
            Console.WriteLine(check("Founder"));
            Console.ReadLine();
        }
        public static string check(string str)
        {
            if (str.StartsWith("F") && str.EndsWith("B"))
            {
                return "FizzBuzz";
            }
            else if (str.StartsWith("F"))
                return "Fizz";
            else if (str.EndsWith("B"))
                return "Buzz";
            else 
                return str;
            
        }
    }
}
