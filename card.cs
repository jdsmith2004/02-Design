using System;


namespace Unit02.Game
{
    /// <summary>
    /// An object with a number between and and 13
    /// </summary> 
    public class Card
    {
        public int value = 0;

        /// <summary>
        /// Constructs a new instance of Card
        /// </summary>
        public Card()
        {
        }

        /// <summary>
        /// Generates a new random value and calculates number on the card
        /// </summary>
        public int Draw()
        {
            Random random = new Random();
            value = random.Next(1, 14);
            return value;
        }
    }
}