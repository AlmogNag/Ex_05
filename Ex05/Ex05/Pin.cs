using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Pin
    {
        public string m_PinValue { get; }

        public Pin(string Pin)
        {
            m_PinValue = Pin; 
        }

        public static Pin GenerateTargetPin()
        {
            // $G$ DSN-999 (-3) Sequence of elements should be represented as sequence of enum values and not as a string or char.
            // $G$ NTT-007 (-10) There's no need to re-instantiate the Random instance each time it is used.
            Random rng = new Random();
            string     allowedLetters = GameConstants.k_AllowedLetters;  
            int        SequenceLength = GameConstants.k_ExpectedLength;
            List<char> poolOfLettersList = allowedLetters.ToList();
            char[]     charsOfGeneratedCode = new char[SequenceLength];
            int        randomIndex;
            string     generatedCode;

            for (int i = 0; i < SequenceLength; i++)
            {
                randomIndex = rng.Next(poolOfLettersList.Count);
                charsOfGeneratedCode[i] = poolOfLettersList[randomIndex];
                poolOfLettersList.RemoveAt(randomIndex);
            }

            generatedCode = new string(charsOfGeneratedCode);
            return new Pin(generatedCode);
            // $G$ CSS-027 (-2) Missing blank line before return statement.
        }
        // $G$ CSS-027 (-1) Unnecessary blank line.

    }
}
