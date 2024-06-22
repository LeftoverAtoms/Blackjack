using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Blackjack.UI
{
    public sealed class Card : Image
    {
        public static string[] Suits { get; } = ["Hearts", "Diamonds", "Clubs", "Spades"];
        public static string[] Names { get; } = ["Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"];

        public string Title { get; }
        public string Suit { get; }
        public string Name { get; }

        private static Texture2D m_texture;
        private static Dictionary<(string, string), Rectangle> m_atlas;

        public Card(string suit, string name)
        {
            Texture = m_texture;
            Source = m_atlas[(suit, name)];

            Title = string.Join(' ', name, "of", suit);
            Suit = suit;
            Name = name;
        }

        public static void LoadContent(ContentManager content)
        {
            m_texture = content.Load<Texture2D>("Textures/Cards");
            m_atlas = new Dictionary<(string, string), Rectangle>(52)
            {
                // Clubs
                [(Suits[2], Names[0])] = new Rectangle(3, 3, 58, 58),
                [(Suits[2], Names[1])] = new Rectangle(259, 3, 58, 58),
                [(Suits[2], Names[2])] = new Rectangle(3, 67, 58, 58),
                [(Suits[2], Names[3])] = new Rectangle(259, 67, 58, 58),
                [(Suits[2], Names[4])] = new Rectangle(3, 131, 58, 58),
                [(Suits[2], Names[5])] = new Rectangle(259, 131, 58, 58),
                [(Suits[2], Names[6])] = new Rectangle(3, 195, 58, 58),
                [(Suits[2], Names[7])] = new Rectangle(259, 195, 58, 58),
                [(Suits[2], Names[8])] = new Rectangle(3, 259, 58, 58),
                [(Suits[2], Names[9])] = new Rectangle(259, 259, 58, 58),
                [(Suits[2], Names[10])] = new Rectangle(3, 323, 58, 58),
                [(Suits[2], Names[11])] = new Rectangle(259, 323, 58, 58),
                [(Suits[2], Names[12])] = new Rectangle(3, 387, 58, 58),

                // Diamonds
                [(Suits[1], Names[0])] = new Rectangle(67, 3, 58, 58),
                [(Suits[1], Names[1])] = new Rectangle(323, 3, 58, 58),
                [(Suits[1], Names[2])] = new Rectangle(67, 67, 58, 58),
                [(Suits[1], Names[3])] = new Rectangle(323, 67, 58, 58),
                [(Suits[1], Names[4])] = new Rectangle(67, 131, 58, 58),
                [(Suits[1], Names[5])] = new Rectangle(323, 131, 58, 58),
                [(Suits[1], Names[6])] = new Rectangle(67, 195, 58, 58),
                [(Suits[1], Names[7])] = new Rectangle(323, 195, 58, 58),
                [(Suits[1], Names[8])] = new Rectangle(67, 259, 58, 58),
                [(Suits[1], Names[9])] = new Rectangle(323, 259, 58, 58),
                [(Suits[1], Names[10])] = new Rectangle(67, 323, 58, 58),
                [(Suits[1], Names[11])] = new Rectangle(323, 323, 58, 58),
                [(Suits[1], Names[12])] = new Rectangle(67, 387, 58, 58),

                // Hearts
                [(Suits[0], Names[0])] = new Rectangle(131, 3, 58, 58),
                [(Suits[0], Names[1])] = new Rectangle(387, 3, 58, 58),
                [(Suits[0], Names[2])] = new Rectangle(131, 67, 58, 58),
                [(Suits[0], Names[3])] = new Rectangle(387, 67, 58, 58),
                [(Suits[0], Names[4])] = new Rectangle(131, 131, 58, 58),
                [(Suits[0], Names[5])] = new Rectangle(387, 131, 58, 58),
                [(Suits[0], Names[6])] = new Rectangle(131, 195, 58, 58),
                [(Suits[0], Names[7])] = new Rectangle(387, 195, 58, 58),
                [(Suits[0], Names[8])] = new Rectangle(131, 259, 58, 58),
                [(Suits[0], Names[9])] = new Rectangle(387, 259, 58, 58),
                [(Suits[0], Names[10])] = new Rectangle(131, 323, 58, 58),
                [(Suits[0], Names[11])] = new Rectangle(387, 323, 58, 58),
                [(Suits[0], Names[12])] = new Rectangle(131, 387, 58, 58),

                // Spades
                [(Suits[3], Names[0])] = new Rectangle(195, 3, 58, 58),
                [(Suits[3], Names[1])] = new Rectangle(451, 3, 58, 58),
                [(Suits[3], Names[2])] = new Rectangle(195, 67, 58, 58),
                [(Suits[3], Names[3])] = new Rectangle(451, 67, 58, 58),
                [(Suits[3], Names[4])] = new Rectangle(195, 131, 58, 58),
                [(Suits[3], Names[5])] = new Rectangle(451, 131, 58, 58),
                [(Suits[3], Names[6])] = new Rectangle(195, 195, 58, 58),
                [(Suits[3], Names[7])] = new Rectangle(451, 195, 58, 58),
                [(Suits[3], Names[8])] = new Rectangle(195, 259, 58, 58),
                [(Suits[3], Names[9])] = new Rectangle(451, 259, 58, 58),
                [(Suits[3], Names[10])] = new Rectangle(195, 323, 58, 58),
                [(Suits[3], Names[11])] = new Rectangle(451, 323, 58, 58),
                [(Suits[3], Names[12])] = new Rectangle(195, 387, 58, 58),
            };
        }

        public int GetValue()
        {
            return Name switch
            {
                // Additional points will be given when eligible.
                "Ace" => 1,

                "Two" => 2,
                "Three" => 3,
                "Four" => 4,
                "Five" => 5,
                "Six" => 6,
                "Seven" => 7,
                "Eight" => 8,
                "Nine" => 9,
                "Ten" => 10,
                "Jack" => 10,
                "Queen" => 10,
                "King" => 10,

                // Invalid card name.
                _ => throw new NotImplementedException()
            };
        }
    }
}