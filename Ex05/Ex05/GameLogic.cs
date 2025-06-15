using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class GameLogic
    {
        public GameLogic()
        {
            StartGame();
        }

        public void StartGame()
        {
            // $G$ DSN-002 (-20) UI class should have a reference to the logic class and not the other way around.
            // Also the reference should be defined as a data member.
            // $G$ DSN-003 (-3) The code should be divided to methods.
            GameUI gameUI = new GameUI();
            bool         isKeepPlaying = true;
            bool         isGameWon;
            int          numberOfGuesses;
            List<Pin>    historyOfPins;
            List<Result> historyOfFeedbacks;
            Pin          targetPin;
            Pin          currentPin;
            Result       currentResult;
            int          guessCount = 0;

            while (isKeepPlaying) 
            {
                isGameWon = false;
                numberOfGuesses = gameUI.getNumberOfGuesses();
                historyOfPins = new List<Pin>();
                historyOfFeedbacks = new List<Result>();
                targetPin = Pin.GenerateTargetPin();
                // $G$ DSN-002 (0) UI needs to ask the logic layer if attempts are done. UI should not control game flow logic like number of attempts.
                for (int i = 0; i < numberOfGuesses; i++)
                {
                    gameUI.ClearScreen();
                    gameUI.PrintTheBoard(historyOfPins,historyOfFeedbacks); 
                    currentPin = gameUI.GetUserGuess();

                    if (currentPin.m_PinValue == "Q")
                    {
                        gameUI.ClearScreen();
                        gameUI.ShowExit();
                        return;
                        // $G$ CSS-027 (-2) Missing blank line before return statement.
                    }

                    currentResult = new Result(currentPin, targetPin);
                    historyOfFeedbacks.Add(currentResult);
                    historyOfPins.Add(currentPin);

                    if (currentResult.GetResult() == GameConstants.k_WinResult)
                    {
                        guessCount = i + 1;
                        isGameWon = true;
                        break;
                    }
                }

                gameUI.ClearScreen();
                gameUI.PrintTheBoard(historyOfPins, historyOfFeedbacks);

                if (!isGameWon)
                {
                    gameUI.ShowLose(targetPin.m_PinValue);
                }
                // $G$ CSS-027 (-1) Unnecessary blank line.
                else
                {
                    gameUI.ShowWin(guessCount);
                }

                gameUI.ShowPlayAgain(ref isKeepPlaying);
                if (isKeepPlaying)
                {
                    gameUI.ClearScreen();
                }
                else
                {
                    gameUI.ShowExit();
                }
                // $G$ CSS-027 (-1) Unnecessary blank line.
            }
            // $G$ CSS-027 (-1) Unnecessary blank line.
        }
    }
}
