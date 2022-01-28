using System;
using System.Collections.Generic;

namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    { 
        bool isPlaying = true;
        bool keepPlaying = true;
        int totalScore = 300;
        string playerGuess;   
        int firstCard;     
        int secondCard;     
        public Director()
        {
        }
        public void StartGame()
        {
            while (isPlaying & keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
        public void GetInputs()
        {
            Card card = new Card();
            card.Draw();
            firstCard = card.value;
            card.Draw();
            secondCard = card.value;
            Console.WriteLine($"The card is: {firstCard}");
            Console.Write("Higher or Lower? [h/l]: ");
            playerGuess = Console.ReadLine();       
        }
        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }
            if (playerGuess == "h")
            {
                if (secondCard >= firstCard)
                {
                    totalScore += 100;
                } else
                {
                    totalScore -= 75;
                }
            } else
            {
                if (secondCard < firstCard)
                {
                    totalScore += 100;
                } else
                {
                    totalScore -= 75;
                }
            }
        }
        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }
            string continuePlaying;
            Console.WriteLine($"Next card was: {secondCard}");
            Console.WriteLine($"Your Score is: {totalScore}");
            
            if (totalScore <= 0)
            {
                isPlaying = false;
            } else
            {
                Console.Write($"Play again? [y/n]: ");
                continuePlaying = Console.ReadLine();
                Console.WriteLine();
                keepPlaying = (continuePlaying == "y");
            }
        }
    }
}
