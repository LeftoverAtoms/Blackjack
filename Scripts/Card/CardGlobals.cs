namespace Blackjack
{
    public static class CardGlobals
    {
        public const int Rows = 9;
        public const int Columns = 13;

        public static Card.Suits[] Suits { get; } = Enum.GetValues<Card.Suits>();
        public static Card.Names[] Values { get; } = Enum.GetValues<Card.Names>();

        private static readonly Dictionary<Card.Names, char[,]> m_art;
        private static readonly char[] m_symbols = ['♥', '♦', '♣', '♠'];

        static CardGlobals()
        {
            m_art = new()
            {
                {
                    Card.Names.Ace, ConvertToCharArray(
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
                    Card.Names.Two, ConvertToCharArray(
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
                    Card.Names.Three, ConvertToCharArray(
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
                    Card.Names.Four, ConvertToCharArray(
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
                    Card.Names.Five, ConvertToCharArray(
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
                    Card.Names.Six, ConvertToCharArray(
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
                    Card.Names.Seven, ConvertToCharArray(
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
                    Card.Names.Eight, ConvertToCharArray(
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
                    Card.Names.Nine, ConvertToCharArray(
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
                    Card.Names.Ten, ConvertToCharArray(
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
                    Card.Names.Jack, ConvertToCharArray(
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
                    Card.Names.Queen, ConvertToCharArray(
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
                    Card.Names.King, ConvertToCharArray(
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
            if (m_art.TryGetValue(card.Name, out var input))
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