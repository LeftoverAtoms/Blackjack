using System;

namespace Blackjack
{
    public abstract class BasePawn
    {
        public Table Table { get; set; }

        public Hand[] Hands { get; } = [new Hand(), new Hand()];

        public int BetCash { get; private set; }

        public void Enter(Table table)
        {
            int seat = -1;

            // Try to sit at a random spot at the table.
            int attempts = 0;
            var rng = new Random();
            while (attempts < 64)
            {
                int index = rng.Next(table.Players.Length);
                if (table.Players[index] == null)
                {
                    seat = index;
                    break;
                }
                attempts++;
            }

            // Found a seat.
            if (seat != -1)
            {
                Table = table;
                Table.Players[seat] = this;
            }
        }
        public void Exit()
        {
            int seat = Array.FindIndex(Table.Players, plr => (plr == this));
            Table.Players[seat] = null;
            Table = null;
        }

        public void Bet(int amount)
        {
            BetCash = amount;
        }
        public void Hit()
        {
            var card = Table.Deck.Draw();
            Hands[0].Cards.Add(card);
        }
        public void Stand() { }
    }
}