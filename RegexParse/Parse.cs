using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexParse
{
    class Parse
    {
        public string input = "0,5X^2+8X+5,5=0";
        public string input2 = "1X^2+8X+1=0";
        public string sint = "aX^2+bX+c=0";
        public void ParseEquation()
        {
            double a;
            double b;
            double c;
            //double d;
            //double[] result = new double[3] { 0, 0, 0 };
            
            var parts = input.Split("X^2");
            a = float.Parse(parts[0]);
            parts = parts[1].Split("X");
            b = float.Parse(parts[0]);
            parts = parts[1].Split("=");
            c = float.Parse(parts[0]);

            Console.WriteLine($"{sint}");
            Console.WriteLine($"input: {input}");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");

            /*
            d = (b * b) - (4 * a * c);

            if (d < 0)
            {
                result[2] = 1;
            }
            if (d == 0)
            {
                result[0] = (-b/(2*a));
                result[1] = result[0];
            }
            if (d > 0)
            {
                result[0] = (-b+Math.Sqrt(d))/(2*a);
                result[1] = (-b-Math.Sqrt(d)) / (2 * a);
            }

            Console.WriteLine($"Входные данные: {input}");

            if (result[2] != 1)
            {
                Console.WriteLine($"Корень 1: {result[0]}");
                Console.WriteLine($"Корень 2: {result[1]}");
            }
            else
            {
                Console.WriteLine($"Корней нет");
            }
            */
        }


        public void ParseWithRegex()
        {
            double a;
            double b;
            double c;
            //double d;
            //double[] result = new double[3] { 0, 0, 0 };
            

            Regex regex = new Regex(@"([0-9]+)X\^2\+([0-9]+)X\+([0-9]+)=0");
            Match match = regex.Match(input2);

            
                a = float.Parse(match.Groups[1].Value);
                b = float.Parse(match.Groups[2].Value);
                c = float.Parse(match.Groups[3].Value);

            Console.WriteLine($"{sint}");
            Console.WriteLine($"input: {input2}");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");

            /*
            d = (b * b) - (4 * a * c);

            if (d < 0)
            {
                result[2] = 1;
            }
            if (d == 0)
            {
                result[0] = (-b / (2 * a));
                result[1] = result[0];
            }
            if (d > 0)
            {
                result[0] = (-b + Math.Sqrt(d)) / (2 * a);
                result[1] = (-b - Math.Sqrt(d)) / (2 * a);
            }
            Console.WriteLine($"С помощью класса Regex");
            Console.WriteLine($"Входные данные: {input}");

            if (result[2] != 1)
            {
                Console.WriteLine($"Корень 1: {result[0]}");
                Console.WriteLine($"Корень 2: {result[1]}");
            }
            else
            {
                Console.WriteLine($"Корней нет");
            }
            */

        }
    }
}
