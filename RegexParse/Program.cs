using System;

namespace RegexParse
{
    class Program
    {
        static void Main(string[] args)
        {
            new Parse().ParseEquation();
            Console.WriteLine($"////////////////////////////////////////////////////////////");
            new Parse().ParseWithRegex();
        }
    }
}
