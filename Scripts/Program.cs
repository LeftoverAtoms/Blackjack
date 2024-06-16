using System.Text;

namespace Blackjack
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            var deck = new Deck();
            deck.Shuffle();

            deck.Draw()?.Render();
            deck.Draw()?.Render();
            deck.Draw()?.Render();

            deck.Collect();
            deck.Shuffle();
        }
    }
}