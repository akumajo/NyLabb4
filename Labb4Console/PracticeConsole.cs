using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordLibrary;

namespace Labb4Console
{
    class PracticeConsole
    {
        static public float AmountOfRightGuesses { get; private set; }
        static public float AmountOfTotalGuesses { get; private set; }

        private string theRandomWord;
        private string correctGuess;
        private string fromThisLanguage;
        private string toThisLanguage;

        public PracticeConsole(Word _randomWord, WordList _loadedList)
        {
            theRandomWord = _randomWord.Translations[_randomWord.FromLanguage];
            correctGuess = _randomWord.Translations[_randomWord.ToLanguage];
            fromThisLanguage = _loadedList.Languages[_randomWord.FromLanguage];
            toThisLanguage = _loadedList.Languages[_randomWord.ToLanguage];
        }

        public void PrintTotalScore()
        {
            PrintAmountOfGuesses();
            if (AmountOfTotalGuesses == 0 && AmountOfRightGuesses == 0) return;
            float totalScore = AmountOfRightGuesses / AmountOfTotalGuesses;
            totalScore *= 100;
            Console.WriteLine($"You got {totalScore:F0}% of your answers right!");
        }

        public void PrintRightOrWrong(string userInput)
        {
            if (userInput == correctGuess)
            {
                Console.WriteLine("Correct!");
                AmountOfRightGuesses++;
            }
            else
            {
                Console.Write($"Wrong answer! The correct answer would be '{correctGuess}'. Press any key to continue.");
                Console.ReadKey();
                Console.Write($"\rWrong answer! {' ',-100} \n");
            }
            AmountOfTotalGuesses++;
        }

        private void PrintAmountOfGuesses()
        {
            Console.WriteLine($"You practiced {AmountOfTotalGuesses} words.");
        }

        public void Play()
        {
            Console.WriteLine($"Translate the {fromThisLanguage} word '{theRandomWord}' to {toThisLanguage}: ");
        }
        public static void ResetPractice()
        {
            AmountOfRightGuesses = 0;
            AmountOfTotalGuesses = 0;
        }
    }
}
