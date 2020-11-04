using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordLibrary;

namespace NyLabb4
{
    class PracticeForms
    {
        static public float AmountOfRightGuesses { get; set; }
        static public float AmountOfTotalGuesses { get; set; }

        private string theRandomWord;
        private string correctGuess;
        private string fromThisLanguage;
        private string toThisLanguage;

        public PracticeForms(Word _randomWord, WordList _loadedList)
        {
            theRandomWord = _randomWord.Translations[_randomWord.FromLanguage];
            correctGuess = _randomWord.Translations[_randomWord.ToLanguage];
            fromThisLanguage = _loadedList.Languages[_randomWord.FromLanguage];
            toThisLanguage = _loadedList.Languages[_randomWord.ToLanguage];
        }

        public string PrintTotalScore()
        {
            return $"{AmountOfRightGuesses} of {AmountOfTotalGuesses} correct guesses.";
        }

        public string PrintRightorWrong(string userInput)
        {
            AmountOfTotalGuesses++;

            if (userInput != correctGuess)
            {
                return $"The correct answer should be '{correctGuess}'";
            }
            else
            {
                AmountOfRightGuesses++;
                return $"The answer is correct!";
            }
        }

        public string Play()
        {
            return $"Translate the {fromThisLanguage} word '{theRandomWord}' to {toThisLanguage}";
        }
        public static void ResetPractice()
        {
            AmountOfRightGuesses = 0;
            AmountOfTotalGuesses = 0;
        }
    }
}
