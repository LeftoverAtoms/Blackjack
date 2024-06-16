using Extensions;

namespace Blackjack
{
    public sealed class Deck
    {
        private List<Card> Cards { get; } = new List<Card>(52);
        private List<Card> Dealt { get; } = new List<Card>(52);

        public Deck()
        {
            foreach (var suit in Card.Suits)
            {
                foreach (var value in Card.Values)
                {
                    Cards.Add(new Card(suit, value));
                }
            }

            Shuffle();
        }

        public Card? Draw()
        {
            if (Cards.Count > 0)
            {
                var card = Cards[0];
                Cards.RemoveAt(0);
                Dealt.Add(card);
                return card;
            }
            ConsoleColor.Red.WriteLine("Empty deck!");
            return null;
        }

        public void Collect()
        {
            for (int i = 0; i < Dealt.Count; i++)
            {
                var card = Dealt[i];
                Dealt.RemoveAt(i);
                Cards.Add(card);
            }
        }
        public void Shuffle()
        {
            var rng = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }
    }
}