﻿namespace Extensions
{
    public static class Extensions
    {
        public static void WriteLine(this ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor(); // Problematic with asynchronous code.
        }

        public static void Write(this ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor(); // Problematic with asynchronous code.
        }
    }
}