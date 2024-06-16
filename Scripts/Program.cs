namespace Blackjack
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            var deck = new Deck();
            deck.Shuffle();

            deck.Draw();

            deck.Collect();
            deck.Shuffle();
        }
    }
}