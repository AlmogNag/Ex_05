using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
namespace Ex05
{
    internal class GameLogic
    {
        private readonly List<Color> r_TargetColors;
        public GameLogic()
        {
            r_TargetColors = generateTargetColors();
        }

        private List<Color> generateTargetColors()
        {
            List<Color> availableColors = GameConstants.k_AllowedColors.ToList(); // constant from GameConstants.cs
            Random rnd = new Random();
            return availableColors.OrderBy(_ => rnd.Next()).Take(4).ToList();
        }

        public List<Color> TargetColors => r_TargetColors;

        public List<Color> GetFeedback(List<Color> i_UserGuess)
        {
            var feedback = new List<Color>();
            var targetFlags = new bool[4];
            var guessFlags = new bool[4];

            // Step 1: Find exact matches (black pegs)
            for (int currPosition = 0; currPosition < 4; currPosition++)
            {
                if (i_UserGuess[currPosition] == r_TargetColors[currPosition])
                {
                    feedback.Add(Color.Black);
                    targetFlags[currPosition] = true;
                    guessFlags[currPosition] = true;
                }
            }

            // Step 2: Find color-only matches (yellow pegs)
            for (int currPosition = 0; currPosition < 4; currPosition++)
            {
                if (guessFlags[currPosition]) continue;

                for (int targetPosition = 0; targetPosition < 4; targetPosition++)
                {
                    if (!targetFlags[targetPosition] && i_UserGuess[currPosition] == r_TargetColors[targetPosition])
                    {
                        feedback.Add(Color.Gold);
                        targetFlags[targetPosition] = true;
                        break;
                    }
                }
            }

            // Fill the rest with empty feedback (gray)
            while (feedback.Count < 4)
            {
                feedback.Add(Color.LightGray);
            }
            return feedback;
        }

        public bool IsWin(List<Color> i_UserGuess)
        {
            return i_UserGuess.SequenceEqual(r_TargetColors);
        }
    }
}
