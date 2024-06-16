namespace Blackjack
{
    public struct Card
    {
        public static CardSuit[] Suits { get; } = Enum.GetValues<CardSuit>();
        public static CardValue[] Values { get; } = Enum.GetValues<CardValue>();

        public string Name { get; }
        public CardSuit Suit { get; }
        public CardValue Value { get; }

        public Card(CardSuit suit, CardValue value)
        {
            Name = $"{value} of {suit}";
            Suit = suit;
            Value = value;
        }
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