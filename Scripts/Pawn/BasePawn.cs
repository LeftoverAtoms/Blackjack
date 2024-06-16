using Extensions;

namespace Blackjack
{
    public abstract class BasePawn
    {
        public bool IsPlaying => Table != null;
        public Table? Table { get; set; }

        public Hand[] Hands { get; } =
        {
            new Hand(),
            new Hand()
        };

        public int BetCash { get; private set; }

        public void Enter(Table table)
        {
            int seat = Array.FindIndex(table.Players, plr => (plr == null));
            if (seat != -1)
            {
                Table = table;
                Table.Players[seat] = this;
            }
        }
        public void Exit()
        {
            if (!IsPlaying)
            {
                ConsoleColor.Red.WriteLine("Cannot exit, we are not part of any game!");
                return;
            }

            int seat = Array.FindIndex(Table.Players, plr => (plr == this));
            Table.Players[seat] = null;
            Table = null;
        }

        public void Bet(int amount)
        {
            BetCash = amount;
            ConsoleColor.White.WriteLine($"Bet ${amount}");
        }
        public void Hit()
        {
            if (!IsPlaying)
            {
                ConsoleColor.Red.WriteLine("Cannot exit, we are not part of any game!");
                return;
            }

            var card = Table.Deck.Draw();
            if (card != null)
            {
                Hands[0].Cards.Add(card.Value);
                Hands[0].Display();
            }
        }
        public void Stand()
        {
            ConsoleColor.White.WriteLine("Stand");
        }
    }
}