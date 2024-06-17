namespace Blackjack
{
    public static class CardGlobals
    {
        public const int Rows = 9;
        public const int Columns = 13;

        public static CardSuit[] Suits { get; } = Enum.GetValues<CardSuit>();
        public static CardValue[] Values { get; } = Enum.GetValues<CardValue>();

        private static readonly Dictionary<CardValue, char[,]> m_art;
        private static readonly char[] m_symbols = ['♥', '♦', '♣', '♠'];

        static CardGlobals()
        {
            m_art = new()
            {
                {
                    CardValue.Ace, ConvertToCharArray(
                    "╭───────────╮",
                    "│A          │",
                    "│           │",
                    "│           │",
                    "│     @     │",
                    "│           │",
                    "│           │",
                    "│          A│",
                    "╰───────────╯"
                )},
                {
                    CardValue.Two, ConvertToCharArray(
                    "╭───────────╮",
                    "│2          │",
                    "│     @     │",
                    "│           │",
                    "│           │",
                    "│           │",
                    "│     @     │",
                    "│          2│",
                    "╰───────────╯"
                )},
                {
                    CardValue.Three, ConvertToCharArray(
                    "╭───────────╮",
                    "│3          │",
                    "│     @     │",
                    "│           │",
                    "│     @     │",
                    "│           │",
                    "│     @     │",
                    "│          3│",
                    "╰───────────╯"
                )},
                {
                    CardValue.Four, ConvertToCharArray(
                    "╭───────────╮",
                    "│4          │",
                    "│   @   @   │",
                    "│           │",
                    "│           │",
                    "│           │",
                    "│   @   @   │",
                    "│          4│",
                    "╰───────────╯"
                )},
                {
                    CardValue.Five, ConvertToCharArray(
                    "╭───────────╮",
                    "│5          │",
                    "│   @   @   │",
                    "│           │",
                    "│     @     │",
                    "│           │",
                    "│   @   @   │",
                    "│          5│",
                    "╰───────────╯"
                )},
                {
                    CardValue.Six, ConvertToCharArray(
                    "╭───────────╮",
                    "│6          │",
                    "│   @   @   │",
                    "│           │",
                    "│   @   @   │",
                    "│           │",
                    "│   @   @   │",
                    "│          6│",
                    "╰───────────╯"
                )},
                {
                    CardValue.Seven, ConvertToCharArray(
                    "╭───────────╮",
                    "│7          │",
                    "│   @   @   │",
                    "│     @     │",
                    "│   @   @   │",
                    "│           │",
                    "│   @   @   │",
                    "│          7│",
                    "╰───────────╯"
                )},
                {
                    CardValue.Eight, ConvertToCharArray(
                    "╭───────────╮",
                    "│8          │",
                    "│   @   @   │",
                    "│     @     │",
                    "│   @   @   │",
                    "│     @     │",
                    "│   @   @   │",
                    "│          8│",
                    "╰───────────╯"
                )},
                {
                    CardValue.Nine, ConvertToCharArray(
                    "╭───────────╮",
                    "│9          │",
                    "│   @   @   │",
                    "│   @   @   │",
                    "│     @     │",
                    "│   @   @   │",
                    "│   @   @   │",
                    "│          9│",
                    "╰───────────╯"
                )},
                {
                    CardValue.Ten, ConvertToCharArray(
                    "╭───────────╮",
                    "│10         │",
                    "│   @   @   │",
                    "│   @   @   │",
                    "│   @   @   │",
                    "│   @   @   │",
                    "│   @   @   │",
                    "│         10│",
                    "╰───────────╯"
                )},
                {
                    CardValue.Jack, ConvertToCharArray(
                    "╭───────────╮",
                    "│J          │",
                    "│           │",
                    "│           │",
                    "│     @     │",
                    "│           │",
                    "│           │",
                    "│          J│",
                    "╰───────────╯"
                )},
                {
                    CardValue.Queen, ConvertToCharArray(
                    "╭───────────╮",
                    "│Q          │",
                    "│           │",
                    "│           │",
                    "│     @     │",
                    "│           │",
                    "│           │",
                    "│          Q│",
                    "╰───────────╯"
                )},
                {
                    CardValue.King, ConvertToCharArray(
                    "╭───────────╮",
                    "│K          │",
                    "│           │",
                    "│           │",
                    "│     @     │",
                    "│           │",
                    "│           │",
                    "│          K│",
                    "╰───────────╯"
                )}
            };
        }

        public static char[,] GetGraphic(Card card)
        {
            char[,] output = new char[0, 0];
            if (m_art.TryGetValue(card.Value, out var input))
            {
                output = new char[Rows, Columns];

                var symbol = m_symbols[(int)card.Suit];

                for (int y = 0; y < Rows; y++)
                {
                    for (int x = 0; x < Columns; x++)
                    {
                        var chr = input[y, x];

                        if (chr == '@')
                            chr = symbol;

                        output[y, x] = chr;
                    }
                }
            }
            return output;
        }

        private static char[,] ConvertToCharArray(params string[] input)
        {
            var output = new char[Rows, Columns];
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Columns; x++)
                {
                    output[y, x] = input[y][x];
                }
            }
            return output;
        }
    }
}