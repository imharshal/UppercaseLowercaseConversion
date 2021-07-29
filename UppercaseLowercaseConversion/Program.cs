using System;

namespace UppercaseLowercaseConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter a string");
            str = Console.ReadLine();
            Console.WriteLine("In Uppercase: {0}",str.ToUpper());
            Console.WriteLine("In Lowecase: {0}", str.ToLower());

        }
    }
}
