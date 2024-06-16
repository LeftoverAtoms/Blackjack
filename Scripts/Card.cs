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
            ConsoleColor.Red.WriteLine(string.Format(ASCII.GetValueOrDefault(Value), Symbols[(int)Suit]));
        }

        private static Dictionary<CardValue, string> ASCII { get; } = new()
        {
            {
                CardValue.Ace,
                "╭───────────╮\r\n" +
                "│A          │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│     {0}     │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│          A│\r\n" +
                "╰───────────╯"
            },
            {
                CardValue.Two,
                "╭───────────╮\r\n" +
                "│2          │\r\n" +
                "│     {0}     │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│     {0}     │\r\n" +
                "│          2│\r\n" +
                "╰───────────╯"
            },
            {
                CardValue.Three,
                "╭───────────╮\r\n" +
                "│3          │\r\n" +
                "│     {0}     │\r\n" +
                "│           │\r\n" +
                "│     {0}     │\r\n" +
                "│           │\r\n" +
                "│     {0}     │\r\n" +
                "│          3│\r\n" +
                "╰───────────╯"
            },
            {
                CardValue.Four,
                "╭───────────╮\r\n" +
                "│4          │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│          4│\r\n" +
                "╰───────────╯"
            },
            {
                CardValue.Five,
                "╭───────────╮\r\n" +
                "│5          │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│           │\r\n" +
                "│     {0}     │\r\n" +
                "│           │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│          5│\r\n" +
                "╰───────────╯"
            },
            {
                CardValue.Six,
                "╭───────────╮\r\n" +
                "│6          │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│           │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│           │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│          6│\r\n" +
                "╰───────────╯"
            },
            {
                CardValue.Seven,
                "╭───────────╮\r\n" +
                "│7          │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│     {0}     │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│           │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│          7│\r\n" +
                "╰───────────╯"
            },
            {
                CardValue.Eight,
                "╭───────────╮\r\n" +
                "│8          │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│     {0}     │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│     {0}     │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│          8│\r\n" +
                "╰───────────╯"
            },
            {
                CardValue.Nine,
                "╭───────────╮\r\n" +
                "│9          │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│     {0}     │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│          9│\r\n" +
                "╰───────────╯"
            },
            {
                CardValue.Ten,
                "╭───────────╮\r\n" +
                "│10         │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│   {0}   {0}   │\r\n" +
                "│         10│\r\n" +
                "╰───────────╯"
            },
            {
                CardValue.Jack,
                "╭───────────╮\r\n" +
                "│J          │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│     {0}     │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│          J│\r\n" +
                "╰───────────╯"
            },
            {
                CardValue.Queen,
                "╭───────────╮\r\n" +
                "│Q          │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│     {0}     │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│          Q│\r\n" +
                "╰───────────╯"
            },
            {
                CardValue.King,
                "╭───────────╮\r\n" +
                "│K          │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│     {0}     │\r\n" +
                "│           │\r\n" +
                "│           │\r\n" +
                "│          K│\r\n" +
                "╰───────────╯"
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