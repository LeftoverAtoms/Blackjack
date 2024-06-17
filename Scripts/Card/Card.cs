namespace Blackjack
{
    public readonly struct Card(Card.Suits suit, Card.Names name)
    {
        public string Title { get; } = string.Join(' ', name, "of", suit);
        public Suits Suit { get; } = suit;
        public Names Name { get; } = name;

        public enum Suits
        {
            Hearts, Diamonds, Clubs, Spades
        }

        public enum Names
        {
            Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
        }
    }
}