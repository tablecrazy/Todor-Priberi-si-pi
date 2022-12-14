using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "dr - Divide Remainder",
            "ex- Exit"
        };

        public static void DivideReminder(double a,double b)
        {
            Console.WriteLine($"{a}%{b} = {a%b}");
        }
        public static void Exit()
        {
            return;
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

        public static void Remaining_Division(double a, double b)
        {
            Console.WriteLine($"{a} % {b} = {a % b}");
        }
    }
}
