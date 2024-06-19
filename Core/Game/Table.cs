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
    }
}