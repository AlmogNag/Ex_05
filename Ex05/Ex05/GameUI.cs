using System;
using System.Collections.Generic;
using System.Linq;
using Ex02.ConsoleUtils;


namespace Ex02
{
    internal class GameUI
    {
        private int m_MaxGuesses;

        public int  getNumberOfGuesses()
        {
            int    numberOfGuesses;
            string input;

            Console.WriteLine("Enter number of guesses (4–10):");

            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out numberOfGuesses)
                    // $G$ CSS-999 (-5) Avoid hardcoded values – use constants or readonly fields instead.
                    // $G$ DSN-002 (0) Input validation logic (such as range checks) should be handled in the logic layer, not in the UI.
                    && numberOfGuesses >= 4
                    && numberOfGuesses <= 10)
                {
                    m_MaxGuesses = numberOfGuesses;
                    return numberOfGuesses;
                }

                // $G$ CSS-999 (0) Avoid hardcoded values in the string – use constants or readonly fields instead.
                Console.WriteLine("Invalid. Please enter an integer between 4 and 10:");
            }
        }

        public void ClearScreen()
        {
            Screen.Clear();
        }

        public void PrintTheBoard(List<Pin> pinsHistory, List<Result> feedbackHistory)
        {
            string horizontalLine = $"|{new string('=', GameConstants.k_PinsColWidth + 2)}|{new string('=', GameConstants.k_ResultColWidth + 2)}|";
            Console.WriteLine(horizontalLine);
            Console.WriteLine($"| {"Pins:",-GameConstants.k_PinsColWidth} | {"Result:",-GameConstants.k_ResultColWidth} |");
            Console.WriteLine(horizontalLine);
            Console.WriteLine($"| {"# # # #",-GameConstants.k_PinsColWidth} | {"",-GameConstants.k_ResultColWidth} |");
            Console.WriteLine(horizontalLine);

            for (int row = 0; row < m_MaxGuesses; row++)
            {
                // $G$ NTT-999 (-1) You should have used string.Empty instead of "".
                string pinsCell = "";
                string resultCell = "";

                if (row < pinsHistory.Count)
                {
                    pinsCell = string.Join(" ", pinsHistory[row].m_PinValue.ToCharArray());
                    resultCell = string.Join(" ", feedbackHistory[row].m_Result.ToCharArray());
                }

                Console.WriteLine($"| {pinsCell,-GameConstants.k_PinsColWidth} | {resultCell,-GameConstants.k_ResultColWidth} |");
                Console.WriteLine(horizontalLine);
            }
        }

        // $G$ CSS-027 (-1) Unnecessary blank lines.

        public Pin  GetUserGuess()
        {
            Console.WriteLine("Enter your guess (4 letters A–H) or Q to quit:");
            string input = Console.ReadLine().ToUpper();

            while (!InputValidityCheck(input))
            {
                Console.WriteLine("Enter your guess (4 letters A–H) or Q to quit:");
                input = Console.ReadLine().ToUpper();
            }
            
            return new Pin(input);
        }

        public bool InputValidityCheck(string i_input)
        {
            bool          isCorrectInput = true;
            int           expectedLength = GameConstants.k_ExpectedLength;
            string        allowedLetters = GameConstants.k_AllowedLetters;
            List<char>    availableLetters = allowedLetters.ToList();
            HashSet<char> seenLetters = new HashSet<char>();

            if (i_input == "Q")
            {
                isCorrectInput = true;
            }

            else if (!i_input.All(char.IsLetter))
            {
                Console.WriteLine("Invalid input: Only English letters are allowed. Please try again.");
                isCorrectInput = false;
            }

            else if (i_input.Length == expectedLength)
            {
                foreach (char currentChar in i_input)
                {
                    if (!availableLetters.Contains(currentChar) || seenLetters.Contains(currentChar))
                    {
                        isCorrectInput = false;
                        break;
                    }

                    seenLetters.Add(currentChar);
                }

                if (!isCorrectInput)
                {
                    // $G$ CSS-999 (-3) The character bounds should be defined as const members instead of hardcoded values in the string message to print.
                    Console.WriteLine("Invalid input: Letters must be unique and from the allowed set (a-h). Please try again.");
                }
            }
            else
            {
                Console.WriteLine($"Invalid input: Input must be exactly {expectedLength} letters. Please try again.");
                isCorrectInput = false;
            }

            return isCorrectInput;
        }

        // $G$ CSS-013 (-5) Bad parameter name (should be in the form of i_PascalCase).
        public void ShowWin(int _numberOfGuessPlayed)
        {
            Console.WriteLine($"Congratulations! You cracked the code in {_numberOfGuessPlayed} Steps!");
        }

        public void ShowLose(string i_targetValue)
        {
            Console.WriteLine("You've run out of attempts, you lose!");
            Console.WriteLine($"the target was: {i_targetValue}");
        }
        // $G$ CSS-015 (0) Bad parameter name. 'ref' parameter should be in io_PascalCase format.
        public void ShowPlayAgain(ref bool keepPlaying)
        {
            Console.WriteLine("Play again? (Y/N):");
            string answer = Console.ReadLine().Trim().ToUpper();

            while (answer != "Y" && answer != "N")
            {
                Console.WriteLine("Invalid input, Play again? (Y/N):");
                answer = Console.ReadLine().Trim().ToUpper();
            }

            if (answer == "Y")
            {
                keepPlaying = true;
            }

            else
            {
                keepPlaying = false;
            }
        }
            
        public void ShowExit()
        {
            Console.WriteLine("Thanks for playing! Goodbye!");
        }
    }
}
