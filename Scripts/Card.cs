using Extensions;

namespace Blackjack
{
    public readonly struct Card
    {
        public static CardSuit[] Suits { get; } = Enum.GetValues<CardSuit>();
        public static CardValue[] Values { get; } = Enum.GetValues<CardValue>();
        public static char[] Symbols { get; } =
        {
            '♥', '♦', '♣', '♠',
        };

        public string Name { get; }
        public CardSuit Suit { get; }
        public CardValue Value { get; }

        public Card(CardSuit suit, CardValue value)
        {
            Name = $"{value} of {suit}";
            Suit = suit;
            Value = value;
        }

        public void Render()
        {
            if (ASCII.TryGetValue(Value, out var art))
            {
                char symbol = Symbols[(int)Suit];
                art = art.Replace('@', symbol);
                ConsoleColor.Red.WriteLine(art);
            }
        }

        private static Dictionary<CardValue, string> ASCII { get; } = new()
        {
            {
                CardValue.Ace,
                "╭───────────╮\r\n" +
                "│A          │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│     @     │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│          A│\r\n" +
                "╰───────────╯\r\n"
            },
            {
                CardValue.Two,
                "╭───────────╮\r\n" +
                "│2          │\r\n" +
                "│     @     │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│     @     │\r\n" +
                "│          2│\r\n" +
                "╰───────────╯\r\n"
            },
            {
                CardValue.Three,
                "╭───────────╮\r\n" +
                "│3          │\r\n" +
                "│     @     │\r\n" +
                "│           │\r\n" +
                "│     @     │\r\n" +
                "│           │\r\n" +
                "│     @     │\r\n" +
                "│          3│\r\n" +
                "╰───────────╯\r\n"
            },
            {
                CardValue.Four,
                "╭───────────╮\r\n" +
                "│4          │\r\n" +
                "│   @   @   │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│   @   @   │\r\n" +
                "│          4│\r\n" +
                "╰───────────╯\r\n"
            },
            {
                CardValue.Five,
                "╭───────────╮\r\n" +
                "│5          │\r\n" +
                "│   @   @   │\r\n" +
                "│           │\r\n" +
                "│     @     │\r\n" +
                "│           │\r\n" +
                "│   @   @   │\r\n" +
                "│          5│\r\n" +
                "╰───────────╯\r\n"
            },
            {
                CardValue.Six,
                "╭───────────╮\r\n" +
                "│6          │\r\n" +
                "│   @   @   │\r\n" +
                "│           │\r\n" +
                "│   @   @   │\r\n" +
                "│           │\r\n" +
                "│   @   @   │\r\n" +
                "│          6│\r\n" +
                "╰───────────╯\r\n"
            },
            {
                CardValue.Seven,
                "╭───────────╮\r\n" +
                "│7          │\r\n" +
                "│   @   @   │\r\n" +
                "│     @     │\r\n" +
                "│   @   @   │\r\n" +
                "│           │\r\n" +
                "│   @   @   │\r\n" +
                "│          7│\r\n" +
                "╰───────────╯\r\n"
            },
            {
                CardValue.Eight,
                "╭───────────╮\r\n" +
                "│8          │\r\n" +
                "│   @   @   │\r\n" +
                "│     @     │\r\n" +
                "│   @   @   │\r\n" +
                "│     @     │\r\n" +
                "│   @   @   │\r\n" +
                "│          8│\r\n" +
                "╰───────────╯\r\n"
            },
            {
                CardValue.Nine,
                "╭───────────╮\r\n" +
                "│9          │\r\n" +
                "│   @   @   │\r\n" +
                "│   @   @   │\r\n" +
                "│     @     │\r\n" +
                "│   @   @   │\r\n" +
                "│   @   @   │\r\n" +
                "│          9│\r\n" +
                "╰───────────╯\r\n"
            },
            {
                CardValue.Ten,
                "╭───────────╮\r\n" +
                "│10         │\r\n" +
                "│   @   @   │\r\n" +
                "│   @   @   │\r\n" +
                "│   @   @   │\r\n" +
                "│   @   @   │\r\n" +
                "│   @   @   │\r\n" +
                "│         10│\r\n" +
                "╰───────────╯\r\n"
            },
            {
                CardValue.Jack,
                "╭───────────╮\r\n" +
                "│J          │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│     @     │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│          J│\r\n" +
                "╰───────────╯\r\n"
            },
            {
                CardValue.Queen,
                "╭───────────╮\r\n" +
                "│Q          │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│     @     │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│          Q│\r\n" +
                "╰───────────╯\r\n"
            },
            {
                CardValue.King,
                "╭───────────╮\r\n" +
                "│K          │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│     @     │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│          K│\r\n" +
                "╰───────────╯\r\n"
            },
        };
    }

    public enum CardSuit
    {
        Hearts, Diamonds, Clubs, Spades
    }

    public enum CardValue
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }
}