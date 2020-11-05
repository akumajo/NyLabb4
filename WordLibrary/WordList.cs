using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace WordLibrary
{
    public class WordList
    {
        public string Name { get; }
        public string[] Languages { get; }
        List<Word> words = new List<Word>();
        static private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Labb4\";

        public WordList(string _name, params string[] _languages)
        {
            Name = _name;
            Languages = _languages.ToArray();
        }

        public static string[] GetLists()
        {
            DirectoryInfo di = new DirectoryInfo(filePath);
            FileInfo[] allDatFiles = di.GetFiles("*.dat");
            return allDatFiles.Select(f => Path.GetFileNameWithoutExtension(f.Name)).ToArray();
        }

        public static WordList LoadList(string name)
        {
            if (File.Exists(filePath + name + ".dat"))
            {
                using (StreamReader sr = new StreamReader(filePath + name + ".dat", true))
                {
                    string header = sr.ReadLine();
                    string[] languages = header.Remove(header.LastIndexOf(';')).Split(';');
                    WordList loadedList = new WordList(name, languages);

                    while (!sr.EndOfStream)
                    {
                        string wordLine = sr.ReadLine();
                        if (string.IsNullOrEmpty(wordLine))
                            break;

                        string[] words = wordLine.Remove(wordLine.LastIndexOf(';')).Split(';');
                        loadedList.words.Add(new Word(words));
                    }
                    return loadedList;
                }
            }
            return null;
        }

        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(filePath + Name + ".dat", false))
            {
                for (int i = 0; i < Languages.Length; i++)
                {
                    sw.Write($"{Languages[i].ToLower()}{';'}");
                }
                sw.WriteLine();

                for (int i = 0; i < words.Count; i++)
                {
                    for (int j = 0; j < Languages.Length; j++)
                    {
                        sw.Write($"{words[i].Translations[j].ToLower()}{';'}");
                    }
                    sw.WriteLine();
                }
            }
        }

        public void Add(params string[] translations)
        {
            words.Add(new Word(translations));
        }

        public bool Remove(int translation, string word)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Translations[translation] == word)
                {
                    words.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public int Count()
        {
            return words.Count;
        }

        public void List(int sortByTranslation, Action<string> showTranslation)
        {
            var sortedList = words.OrderBy(t => t.Translations[sortByTranslation]).ToList();

            showTranslation($"{String.Join(";", Languages)}{';'}".ToUpper());

            for (int i = 0; i < sortedList.Count; i++)
            {
                showTranslation($"{String.Join(";", sortedList[i].Translations)}{';'}");
            }
        }

        public Word GetWordToPractice()
        {
            Random rnd = new Random();
            int index = rnd.Next(words.Count);

            int fromLanguage = rnd.Next(0, Languages.Length);
            int toLanguage = rnd.Next(0, Languages.Length);

            while (fromLanguage == toLanguage)
            {
                toLanguage = rnd.Next(0, Languages.Length);
            }

            return new Word(fromLanguage, toLanguage, words[index].Translations);
        }
    }
}