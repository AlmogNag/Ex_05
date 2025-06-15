using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Result
    {
        public string m_Result { get; }
        // $G$ CSS-027 (-2) Missing spacing after ','.
        public Result(Pin pin,Pin target)
        {
            m_Result = CalculateResult (pin.m_PinValue,  target.m_PinValue);
        }

        private string CalculateResult(string i_guessValue, string i_targetValue)
        {
            // $G$ DSN-999 (-5) Feedback should be represented as a collection of feedback options (enum) and not as a string or char.
            // The logic layer doesn't suppose know that the UI present the hits \ misses as 'V' or 'X'
            int correctLetters = 0;
            int    missPlaceLetters = 0; 
            bool[] isUsedInTarget = new bool[i_targetValue.Length];
            bool[] isUsedInGuess = new bool[i_guessValue.Length];

            for (int i = 0; i < i_guessValue.Length; i++)
            {
                if (i_guessValue[i] == i_targetValue[i])
                {
                    correctLetters++;
                    isUsedInGuess[i] = true;
                    isUsedInTarget[i] = true;
                }
            }
            // $G$ CSS-007 (-1) Missing space after each semicolon in the for-loop declaration.
            for (int i = 0;i < i_guessValue.Length;i++)
            {
                if (!isUsedInGuess[i])
                {
                    for (int j = 0; j < i_guessValue.Length; j++)
                    {
                        if (!isUsedInTarget[j] && i_guessValue[i] == i_targetValue[j])
                        {
                            missPlaceLetters++;
                            isUsedInTarget[j] = true; ;
                            break;
                        }
                    }
                }
            }
            return new string ('V', correctLetters) + new string ('X', missPlaceLetters);
            // $G$ NTT-999 (-3) Avoid using operator '+' with strings, instead use alternatives such as StringBuilder / '@' / '$' / string.Format.
            // $G$ CSS-027 (-2) Missing blank line before return statement.
        }

        public string GetResult()
        {
            return m_Result;
        }

        // $G$ CSS-027 (-1) Unnecessary blank line.
    }
}
