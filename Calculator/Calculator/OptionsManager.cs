using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "sabs - SubtractAbs",
            "d - Divide",
             };

        public static void Add(double a, double b)
        {
            Console.WriteLine( $"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine( $"{a} x {b} = {a * b}");
        }
        public static void Divide(double a, double b)
        {
            Console.WriteLine($"{a} : {b} = {a / b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine( $"{a} - {b} = {a - b}");
        }
        public static void SubtractAbs(double a, double b)
        {
            Console.WriteLine($"|{a} - {b}| = {Math.Abs(a - b)}");
        }

    }
}
