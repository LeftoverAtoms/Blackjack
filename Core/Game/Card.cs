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

        public static Dictionary<(string, string), Texture2D> Textures { get; } = new(52);

        public string Title { get; }
        public string Suit { get; }
        public string Name { get; }

        public Card(string suit, string name)
        {
            Texture = Card.Textures[(suit, name)];
            Title = string.Join(' ', name, "of", suit);
            Suit = suit;
            Name = name;
        }

        public static void LoadContent(ContentManager content)
        {
            Textures.Add(("Hearts", "Ace"), content.Load<Texture2D>("Textures/Cards/AceOfHearts"));
            Textures.Add(("Hearts", "Two"), content.Load<Texture2D>("Textures/Cards/TwoOfHearts"));
            Textures.Add(("Hearts", "Three"), content.Load<Texture2D>("Textures/Cards/ThreeOfHearts"));
            Textures.Add(("Hearts", "Four"), content.Load<Texture2D>("Textures/Cards/FourOfHearts"));
            Textures.Add(("Hearts", "Five"), content.Load<Texture2D>("Textures/Cards/FiveOfHearts"));
            Textures.Add(("Hearts", "Six"), content.Load<Texture2D>("Textures/Cards/SixOfHearts"));
            Textures.Add(("Hearts", "Seven"), content.Load<Texture2D>("Textures/Cards/SevenOfHearts"));
            Textures.Add(("Hearts", "Eight"), content.Load<Texture2D>("Textures/Cards/EightOfHearts"));
            Textures.Add(("Hearts", "Nine"), content.Load<Texture2D>("Textures/Cards/NineOfHearts"));
            Textures.Add(("Hearts", "Ten"), content.Load<Texture2D>("Textures/Cards/TenOfHearts"));
            Textures.Add(("Hearts", "Jack"), content.Load<Texture2D>("Textures/Cards/JackOfHearts"));
            Textures.Add(("Hearts", "Queen"), content.Load<Texture2D>("Textures/Cards/QueenOfHearts"));
            Textures.Add(("Hearts", "King"), content.Load<Texture2D>("Textures/Cards/KingOfHearts"));

            Textures.Add(("Diamonds", "Ace"), content.Load<Texture2D>("Textures/Cards/AceOfDiamonds"));
            Textures.Add(("Diamonds", "Two"), content.Load<Texture2D>("Textures/Cards/TwoOfDiamonds"));
            Textures.Add(("Diamonds", "Three"), content.Load<Texture2D>("Textures/Cards/ThreeOfDiamonds"));
            Textures.Add(("Diamonds", "Four"), content.Load<Texture2D>("Textures/Cards/FourOfDiamonds"));
            Textures.Add(("Diamonds", "Five"), content.Load<Texture2D>("Textures/Cards/FiveOfDiamonds"));
            Textures.Add(("Diamonds", "Six"), content.Load<Texture2D>("Textures/Cards/SixOfDiamonds"));
            Textures.Add(("Diamonds", "Seven"), content.Load<Texture2D>("Textures/Cards/SevenOfDiamonds"));
            Textures.Add(("Diamonds", "Eight"), content.Load<Texture2D>("Textures/Cards/EightOfDiamonds"));
            Textures.Add(("Diamonds", "Nine"), content.Load<Texture2D>("Textures/Cards/NineOfDiamonds"));
            Textures.Add(("Diamonds", "Ten"), content.Load<Texture2D>("Textures/Cards/TenOfDiamonds"));
            Textures.Add(("Diamonds", "Jack"), content.Load<Texture2D>("Textures/Cards/JackOfDiamonds"));
            Textures.Add(("Diamonds", "Queen"), content.Load<Texture2D>("Textures/Cards/QueenOfDiamonds"));
            Textures.Add(("Diamonds", "King"), content.Load<Texture2D>("Textures/Cards/KingOfDiamonds"));

            Textures.Add(("Clubs", "Ace"), content.Load<Texture2D>("Textures/Cards/AceOfClubs"));
            Textures.Add(("Clubs", "Two"), content.Load<Texture2D>("Textures/Cards/TwoOfClubs"));
            Textures.Add(("Clubs", "Three"), content.Load<Texture2D>("Textures/Cards/ThreeOfClubs"));
            Textures.Add(("Clubs", "Four"), content.Load<Texture2D>("Textures/Cards/FourOfClubs"));
            Textures.Add(("Clubs", "Five"), content.Load<Texture2D>("Textures/Cards/FiveOfClubs"));
            Textures.Add(("Clubs", "Six"), content.Load<Texture2D>("Textures/Cards/SixOfClubs"));
            Textures.Add(("Clubs", "Seven"), content.Load<Texture2D>("Textures/Cards/SevenOfClubs"));
            Textures.Add(("Clubs", "Eight"), content.Load<Texture2D>("Textures/Cards/EightOfClubs"));
            Textures.Add(("Clubs", "Nine"), content.Load<Texture2D>("Textures/Cards/NineOfClubs"));
            Textures.Add(("Clubs", "Ten"), content.Load<Texture2D>("Textures/Cards/TenOfClubs"));
            Textures.Add(("Clubs", "Jack"), content.Load<Texture2D>("Textures/Cards/JackOfClubs"));
            Textures.Add(("Clubs", "Queen"), content.Load<Texture2D>("Textures/Cards/QueenOfClubs"));
            Textures.Add(("Clubs", "King"), content.Load<Texture2D>("Textures/Cards/KingOfClubs"));

            Textures.Add(("Spades", "Ace"), content.Load<Texture2D>("Textures/Cards/AceOfSpades"));
            Textures.Add(("Spades", "Two"), content.Load<Texture2D>("Textures/Cards/TwoOfSpades"));
            Textures.Add(("Spades", "Three"), content.Load<Texture2D>("Textures/Cards/ThreeOfSpades"));
            Textures.Add(("Spades", "Four"), content.Load<Texture2D>("Textures/Cards/FourOfSpades"));
            Textures.Add(("Spades", "Five"), content.Load<Texture2D>("Textures/Cards/FiveOfSpades"));
            Textures.Add(("Spades", "Six"), content.Load<Texture2D>("Textures/Cards/SixOfSpades"));
            Textures.Add(("Spades", "Seven"), content.Load<Texture2D>("Textures/Cards/SevenOfSpades"));
            Textures.Add(("Spades", "Eight"), content.Load<Texture2D>("Textures/Cards/EightOfSpades"));
            Textures.Add(("Spades", "Nine"), content.Load<Texture2D>("Textures/Cards/NineOfSpades"));
            Textures.Add(("Spades", "Ten"), content.Load<Texture2D>("Textures/Cards/TenOfSpades"));
            Textures.Add(("Spades", "Jack"), content.Load<Texture2D>("Textures/Cards/JackOfSpades"));
            Textures.Add(("Spades", "Queen"), content.Load<Texture2D>("Textures/Cards/QueenOfSpades"));
            Textures.Add(("Spades", "King"), content.Load<Texture2D>("Textures/Cards/KingOfSpades"));
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