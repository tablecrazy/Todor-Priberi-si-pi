using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = 
            {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "dr - Devide Remainder",
            "ex - Exit"
        };
        public static void Exit()
        {
            return;
        }
    
        public static void DevideRemainder(double a,double b)
        {
            Console.WriteLine($"{ a}%{ b}={ a%b}");
        }

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
    }
}
