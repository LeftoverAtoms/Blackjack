namespace Blackjack
{
    public readonly struct Card(CardSuit suit, CardValue value)
    {
        public string Name { get; } = string.Join(' ', value, "of", suit);
        public CardSuit Suit { get; } = suit;
        public CardValue Value { get; } = value;
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