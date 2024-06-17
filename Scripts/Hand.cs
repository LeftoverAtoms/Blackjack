using Extensions;

namespace Blackjack
{
    public sealed class Hand
    {
        public List<Card> Cards { get; } = new List<Card>(52);

        public void Display()
        {
            // Multi-dimensional collection of cards and their respective rows.
            var graphics = Cards.Select(card => CardGlobals.GetGraphic(card));

            for (int y = 0; y < CardGlobals.Rows; y++)
            {
                foreach (var card in graphics)
                {
                    for (int x = 0; x < CardGlobals.Columns; x++)
                    {
                        ConsoleColor.Red.Write(card[y, x].ToString());
                    }
                }
                Console.WriteLine();
            }
        }
    }
}