using System;

namespace Blackjack
{
    public readonly struct Card
    {
        public static string[] Suits { get; } = ["Hearts", "Diamonds", "Clubs", "Spades"];
        public static string[] Names { get; } = ["Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"];

        public string Title { get; }
        public string Suit { get; }
        public string Name { get; }

        public Card(string suit, string name)
        {
            Title = string.Join(' ', name, "of", suit);
            Suit = suit;
            Name = name;
        }

        public int GetValue()
        {
            return Name switch
            {
                // Additional points will be given when eligible.
                "Ace" => 1,

                "Two" => 2,
                "Three" => 3,
                "Four" => 4,
                "Five" => 5,
                "Six" => 6,
                "Seven" => 7,
                "Eight" => 8,
                "Nine" => 9,
                "Ten" => 10,
                "Jack" => 10,
                "Queen" => 10,
                "King" => 10,

                // Invalid card name.
                _ => throw new NotImplementedException()
            };
        }
    }
}