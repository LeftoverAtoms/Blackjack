namespace Blackjack
{
    public class Human : BasePawn
    {
        public void ProcessInput(string input)
        {
            switch (input[0])
            {
                case 'b':
                {
                    Bet(1000);
                    break;
                }
                case 'h':
                {
                    Hit();
                    break;
                }
                case 's':
                {
                    Stand();
                    break;
                }
            }
        }
    }
}