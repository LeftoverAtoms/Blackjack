namespace Blackjack
{
    public sealed class Table
    {
        public Deck Deck { get; }
        public BasePawn?[] Players { get; }

        public Table(int maxPlayers)
        {
            Deck = new Deck();
            Players = new BasePawn[maxPlayers];
        }
    }
}