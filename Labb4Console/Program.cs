using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WordLibrary;


namespace Labb4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintInstructions();
            }
            if (args.Length > 0)
            {
                UserChoice(args);
            }
        }

        static void AddWords(string[] args)
        {
            GuardClauses.NoSelectedList(args);
            var loadedList = WordList.LoadList(args[1]);
            GuardClauses.LoadedListReturnsNull(loadedList, args[1]);

            bool addWords = true;
            Regex forbiddenChars = new Regex("[;,.:\n]");

            while(addWords)
            {
                string[] translations = new string[loadedList.Languages.Length];
                for (int i = 0; i < loadedList.Languages.Length; i++)
                {
                    Console.Write($"{loadedList.Languages[i].ToUpper()}: ");
                    translations[i] = Console.ReadLine();
                    if (translations[i] == "") { addWords = false; break; }

                    translations[i] = forbiddenChars.Replace(translations[i], "").Trim();
                }
                if (!translations.Contains("")){ loadedList.Add(translations); }
            } 
            loadedList.Save();
        }

        static void PrintInstructions()
        {
            Console.WriteLine("Use any of the following parameters:");
            Console.WriteLine("-lists");
            Console.WriteLine("-new < list name > < language 1 > < language 2 > .. < langauge n >");
            Console.WriteLine("-add < list name >");
            Console.WriteLine("-remove < list name > < language > < word 1 > < word 2 > .. < word n >");
            Console.WriteLine("-words< listname > < sortByLanguage >");
            Console.WriteLine("-count < listname >");
            Console.WriteLine("-practice < listname >");
        }

        static void ShowTranslation(string showTranslation)
        {
            string[] translation = showTranslation.Remove(showTranslation.LastIndexOf(';')).Split(';');
            for (int i = 0; i < translation.Length; i++)
            {
                Console.Write($"{translation[i],-15}");
            }
            Console.WriteLine();
        }

        static void Remove(string[] args)
        {
            GuardClauses.TriedToRemoveNothing(args);
            var loadedList = WordList.LoadList(args[1]);
            GuardClauses.LoadedListReturnsNull(loadedList, args[1]);

            int index = Array.FindIndex(loadedList.Languages, l => l.Contains(args[2]));
            GuardClauses.TheLanguageDoesNotExistInThisList(index);

            string[] word = args.Skip(3).ToArray();
            for (int i = 0; i < word.Length; i++)
            {
                if (loadedList.Remove(index, word[i]) == false)
                {
                    Console.WriteLine($"The word '{word[i]}' does not exist in this list.");
                }

                else
                {
                    Console.WriteLine($"Removed '{word[i]}' from the list.");
                }
            }
            loadedList.Save();
        }

        static void SortList(string[] args)
        {
            GuardClauses.NoSelectedList(args);
            var loadedList = WordList.LoadList(args[1]);

            GuardClauses.LoadedListReturnsNull(loadedList, args[1]);
            GuardClauses.SelectedListDoesntContainWords(loadedList);
            GuardClauses.SelectedListDoesntContainLanguage(loadedList, args[2]);

            if (args.Length < 3)
            {
                loadedList.List(0, ShowTranslation);
            }
            else
            {
                string language = args[2];
                int index = Array.FindIndex(loadedList.Languages, l => l.Contains(language));
                loadedList.List(index, ShowTranslation);
            }
        }

        static void PracticeWords(string[] args)
        {
            GuardClauses.NoSelectedList(args);
            var loadedList = WordList.LoadList(args[1]);
            GuardClauses.LoadedListReturnsNull(loadedList, args[1]);
            GuardClauses.SelectedListDoesntContainWords(loadedList);
            PracticeConsole.ResetPractice();
            while (true)
            {
                Word randomWord = loadedList.GetWordToPractice();
                PracticeConsole practiceMode = new PracticeConsole(randomWord, loadedList);
                practiceMode.Play();

                string userInput = Console.ReadLine();
                if (userInput == "")
                {
                    practiceMode.PrintTotalScore();
                    break;
                }
                practiceMode.PrintRightOrWrong(userInput);
            }
        }

        static void UserChoice(string[] args)
        {
            try
            {
                switch (args[0])
                {
                    case "-lists":
                        PrintAvailableLists();
                        break;

                    case "-new":
                        CreateNewList(args);
                        break;

                    case "-add":
                        AddWords(args);
                        break;

                    case "-remove":
                        Remove(args);
                        break;

                    case "-words":
                        SortList(args);
                        break;

                    case "-count":
                        CountWordsInSelectedList(args);
                        break;

                    case "-practice":
                        PracticeWords(args);
                        break;

                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        static void PrintAvailableLists()
        {
            string[] lists = WordList.GetLists();
            Console.WriteLine("Available word lists: \n");
            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }
        }

        static void CountWordsInSelectedList(string[] args)
        {
            GuardClauses.NoSelectedList(args);
            var loadedList = WordList.LoadList(args[1]);
            GuardClauses.LoadedListReturnsNull(loadedList, args[1]);

            Console.WriteLine($"There's {loadedList.Count()} words in '{loadedList.Name}'");
        }

        static void CreateNewList(string[] args)
        {

            GuardClauses.InputMissingParameters(args);
            WordList newList = new WordList(args[1], args.Skip(2).ToArray());
            newList.Save();

            Console.WriteLine($"A new list called {args[1]} was successfully created.");
            AddWords(args);
            newList.Save();
        }
    }
}