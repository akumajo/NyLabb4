using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLibrary
{
    public class Word
    {
        public string[] Translations { get; }
        public int FromLanguage { get; }
        public int ToLanguage { get; }

        public Word(params string[] _translations)
        {
            Translations = _translations;
        }

        public Word(int _fromLanguage, int _toLanguage, params string[] _translations)
        {
            FromLanguage = _fromLanguage;
            ToLanguage = _toLanguage;
            Translations = _translations;
        }
    }
}