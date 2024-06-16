using Extensions;
using System.Text;

namespace Blackjack
{
    internal sealed class Program
    {
        private static readonly Human m_client = new Human();

        private static void Main(string[] args)
        {
            Window.Modify();

            Console.SetWindowSize(1280 / 8, 720 / 16); // Throws an error when ran on a display smaller than 1280x720.

            Console.OutputEncoding = Encoding.Unicode;

            var table = new Table(maxPlayers: 2);

            m_client.Enter(table);

            while (true)
            {
                var input = Console.ReadLine();
                Console.Clear();
                if (input != null)
                {
                    m_client.ProcessInput(input);
                }
            }
        }
    }
}