using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordLibrary;

namespace HelperClasses
{
    public static class GuardClauses
    {
            public static void NoSelectedList(string[] args)
            {
                if (args.Length < 2)
                {
                    throw new Exception($"You need to specify a list.");
                }
            }

            public static void LoadedListReturnsNull(WordList loadedList, string listName)
            {
                if (loadedList == null)
                {
                    throw new Exception($"A list with the name '{listName}' could not be found.");
                }
            }

            public static void SelectedListDoesntContainWords(WordList loadedList)
            {
                if (loadedList.Count() < 1)
                {
                    throw new Exception($"This list doesn't contain any words.");
                }
            }
            public static void SelectedListDoesntContainLanguage(WordList loadedList, string language)
            {
                if (!loadedList.Languages.Contains(language))
                {
                    throw new Exception($"{loadedList.Name}' doesn't contain the language '{language}'");
                }
            }

            public static void TriedToRemoveNothing(string[] args)
            {
                if (args.Length < 4)
                {
                    throw new Exception($"You didn't specify what you wanted to remove.");
                }
            }

            public static void TheLanguageDoesNotExistInThisList(int index)
            {
                if (index == -1)
                {
                    throw new Exception($"The language you specified does not exist on this list.");
                }
            }
            public static void InputMissingParameters(string[] args)
            {
                if (args.Length < 4)
                {
                    throw new Exception($"You need a list name and atleast two languages to create a new list.");
                }
            }
        }
    }