using Microsoft.Xna.Framework;
using System;

namespace Blackjack
{
    public sealed class Table
    {
        public Deck Deck { get; }
        public BasePawn[] Players { get; }

        public Table(int seats)
        {
            Deck = new Deck();
            Players = new BasePawn[seats];
        }

        public void BeginGame()
        {
            foreach (var pawn in Players)
            {
                if (pawn != null)
                {
                    pawn.Hit();
                }
            }

            SetupUI();
        }

        private void SetupUI()
        {
            int client = Array.FindIndex(Players, pawn => (pawn == Game.LocalClient));
            float angle = 2 * (float)Math.PI / Players.Length;

            int index = client;
            foreach (var _ in Players)
            {
                if (index == Players.Length)
                {
                    index = 0;
                }

                var pawn = Players[index];
                if (pawn != null)
                {
                    var position = Extensions.GetVertex(angle * index, 192, 128) + Game.WindowHalfSize;
                    pawn.Hands[0].Cards[0].Position = position; // Hack
                }

                index++;
            }
        }
    }
}