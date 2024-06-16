using Extensions;
using System.Text;

namespace Blackjack
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            var deck = new Deck();
            deck.Shuffle();

            deck.Draw();

            char s = '♣';

            Console.OutputEncoding = Encoding.Unicode;

            ConsoleColor.DarkRed.WriteLine(
                 "╭───────────╮\r\n" +
                 "│K          │\r\n" +
                $"│           │\r\n" +
                $"│           │\r\n" +
                $"│     {s}     │\r\n" +
                $"│           │\r\n" +
                $"│           │\r\n" +
                 "│          K│\r\n" +
                 "╰───────────╯");
            Console.WriteLine();
            ConsoleColor.DarkRed.WriteLine(
                 "╭───────────╮\r\n" +
                 "│Q          │\r\n" +
                $"│           │\r\n" +
                $"│           │\r\n" +
                $"│     {s}     │\r\n" +
                $"│           │\r\n" +
                $"│           │\r\n" +
                 "│          Q│\r\n" +
                 "╰───────────╯");
            Console.WriteLine();
            ConsoleColor.DarkRed.WriteLine(
                 "╭───────────╮\r\n" +
                 "│J          │\r\n" +
                $"│           │\r\n" +
                $"│           │\r\n" +
                $"│     {s}     │\r\n" +
                $"│           │\r\n" +
                $"│           │\r\n" +
                 "│          J│\r\n" +
                 "╰───────────╯");
            Console.WriteLine();
            ConsoleColor.DarkRed.WriteLine(
                 "╭───────────╮\r\n" +
                 "│10         │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                 "│         10│\r\n" +
                 "╰───────────╯");
            Console.WriteLine();
            ConsoleColor.DarkRed.WriteLine(
                 "╭───────────╮\r\n" +
                 "│9          │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                $"│     {s}     │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                 "│          9│\r\n" +
                 "╰───────────╯");
            Console.WriteLine();
            ConsoleColor.DarkRed.WriteLine(
                 "╭───────────╮\r\n" +
                 "│8          │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                $"│     {s}     │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                $"│     {s}     │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                 "│          8│\r\n" +
                 "╰───────────╯");
            Console.WriteLine();
            ConsoleColor.DarkRed.WriteLine(
                 "╭───────────╮\r\n" +
                 "│7          │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                $"│     {s}     │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                $"│           │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                 "│          7│\r\n" +
                 "╰───────────╯");
            Console.WriteLine();
            ConsoleColor.DarkRed.WriteLine(
                 "╭───────────╮\r\n" +
                 "│6          │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                 "│           │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                 "│           │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                 "│          6│\r\n" +
                 "╰───────────╯");
            Console.WriteLine();
            ConsoleColor.DarkRed.WriteLine(
                 "╭───────────╮\r\n" +
                 "│5          │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                 "│           │\r\n" +
                $"│     {s}     │\r\n" +
                 "│           │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                 "│          5│\r\n" +
                 "╰───────────╯");
            Console.WriteLine();
            ConsoleColor.DarkRed.WriteLine(
                 "╭───────────╮\r\n" +
                 "│4          │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                 "│           │\r\n" +
                 "│           │\r\n" +
                 "│           │\r\n" +
                $"│   {s}   {s}   │\r\n" +
                 "│          4│\r\n" +
                 "╰───────────╯");
            Console.WriteLine();
            ConsoleColor.DarkRed.WriteLine(
                 "╭───────────╮\r\n" +
                 "│3          │\r\n" +
                $"│     {s}     │\r\n" +
                 "│           │\r\n" +
                $"│     {s}     │\r\n" +
                 "│           │\r\n" +
                $"│     {s}     │\r\n" +
                 "│          3│\r\n" +
                 "╰───────────╯");
            Console.WriteLine();
            ConsoleColor.DarkRed.WriteLine(
                 "╭───────────╮\r\n" +
                 "│2          │\r\n" +
                $"│     {s}     │\r\n" +
                 "│           │\r\n" +
                 "│           │\r\n" +
                 "│           │\r\n" +
                $"│     {s}     │\r\n" +
                 "│          2│\r\n" +
                 "╰───────────╯");
            Console.WriteLine();
            ConsoleColor.DarkRed.WriteLine(
                 "╭───────────╮\r\n" +
                 "│A          │\r\n" +
                 "│           │\r\n" +
                 "│           │\r\n" +
                $"│     {s}     │\r\n" +
                 "│           │\r\n" +
                 "│           │\r\n" +
                 "│          A│\r\n" +
                 "╰───────────╯");
            Console.WriteLine();

            deck.Collect();
            deck.Shuffle();
        }
    }
}