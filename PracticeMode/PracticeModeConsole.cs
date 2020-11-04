using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordLibrary;

namespace PracticeMode
{
    public class PracticeModeConsole
    {
        static public float AmountOfRightGuesses { get; set; }
        static public float AmountOfTotalGuesses { get; set; }
        private string theRandomWord;
        private string correctGuess;
        private string fromThisLanguage;
        private string toThisLanguage;

        public PracticeModeConsole(Word _randomWord, WordList _loadedList)
        {
            theRandomWord = _randomWord.Translations[_randomWord.FromLanguage];
            correctGuess = _randomWord.Translations[_randomWord.ToLanguage];
            fromThisLanguage = _loadedList.Languages[_randomWord.FromLanguage];
            toThisLanguage = _loadedList.Languages[_randomWord.ToLanguage];
        }

        public void PrintTotalScore()
        {
            if (AmountOfTotalGuesses == 0 && AmountOfRightGuesses == 0) return;
            float totalScore = AmountOfRightGuesses / AmountOfTotalGuesses;
            totalScore *= 100;
            Console.WriteLine($"You got {totalScore:F0}% of your answers right!");
        }

        public void PracticePrintRightorWrong(string userInput)
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

        public void PrintAmountOfGuesses()
        {
            Console.WriteLine($"You practiced {AmountOfTotalGuesses} words.");
        }

        public void Play()
        {
            Console.WriteLine($"Translate the {fromThisLanguage} word '{theRandomWord}' to {toThisLanguage}: ");
        }
    }
}
