using Extensions;

namespace Blackjack
{
    public sealed class Hand
    {
        public List<Card> Cards { get; } = new List<Card>(52);

        public void Display()
        {
            var cardArts = Cards.Select(card => card.GetGraphic()?.Split(new[] { "\r\n" }, StringSplitOptions.None)).ToList();
            int numberOfLines = cardArts.First().Length;

            for (int line = 0; line < numberOfLines; line++)
            {
                foreach (var cardArt in cardArts)
                {
                    ConsoleColor.Red.Write(cardArt[line] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}