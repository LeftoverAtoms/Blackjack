using Extensions;

namespace Blackjack
{
    public sealed class Hand
    {
        // 12 cards can be held at once, however 13 is the absolute limit
        public List<Card> Cards { get; } = new List<Card>(13);

        public bool Busted { get; private set; }
        public int Value
        {
            get
            {
                int aces = 0;
                int value = 0;
                foreach (var card in Cards)
                {
                    switch (card.Name)
                    {
                        case Card.Names.Ace:
                        {
                            aces++;
                            break;
                        }
                        case Card.Names.Two:
                        {
                            value += 2;
                            break;
                        }
                        case Card.Names.Three:
                        {
                            value += 3;
                            break;
                        }
                        case Card.Names.Four:
                        {
                            value += 4;
                            break;
                        }
                        case Card.Names.Five:
                        {
                            value += 5;
                            break;
                        }
                        case Card.Names.Six:
                        {
                            value += 6;
                            break;
                        }
                        case Card.Names.Seven:
                        {
                            value += 7;
                            break;
                        }
                        case Card.Names.Eight:
                        {
                            value += 8;
                            break;
                        }
                        case Card.Names.Nine:
                        {
                            value += 9;
                            break;
                        }
                        case Card.Names.Ten:
                        case Card.Names.Jack:
                        case Card.Names.Queen:
                        case Card.Names.King:
                        {
                            value += 10;
                            break;
                        }
                    }
                }

                // Legible for ace bonus!
                if (aces == 1 && value <= 10)
                {
                    value += 11;
                }
                // We will bust if we apply the bonus.
                else
                {
                    value += aces;
                }

                Busted = (value > 21);

                return value;
            }
        }

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

            ConsoleColor.Red.Write(Value.ToString());
        }
    }
}