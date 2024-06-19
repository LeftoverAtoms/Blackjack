using System.Collections.Generic;

namespace Blackjack
{
    public sealed class Hand
    {
        // 12 cards can be held at once, however 13 is the absolute limit
        public List<Card> Cards { get; } = new List<Card>(13);

        public bool Busted { get; private set; }

        public int GetScore()
        {
            int score = 0;
            int aces = 0;

            foreach (var card in Cards)
            {
                score += card.GetValue();

                if (card.Name == "Ace")
                {
                    aces += 1;
                }
            }

            // Eligible for the ace bonus!
            if (aces == 1 && score <= 11)
            {
                score += 10;
            }

            // We lost!
            if (score > 21)
            {
                Busted = true;
            }

            return score;
        }
    }
}