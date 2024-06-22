using Blackjack.UI;
using System;
using System.Collections.Generic;

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
                foreach (var name in Card.Names)
                {
                    Cards.Add(new Card(suit, name));
                }
            }

            Shuffle();
        }

        public Card Draw()
        {
            var card = Cards[0];
            Cards.RemoveAt(0);
            Dealt.Add(card);
            return card;
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