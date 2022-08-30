using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_18
{
    internal class Dictionary
    {
        private static int LANGS_NUM = 3;
        private static int WORDS_NUM = 6;
        private string[,] words = new string[LANGS_NUM, WORDS_NUM];
        public Dictionary()
        {
            words[0, 0] = "RU"; words[1, 0] = "EN"; words[2, 0] = "UA";
            words[0, 1] = "книга"; words[1, 1] = "book"; words[2, 1] = "книга";
            words[0, 2] = "ручка"; words[1, 2] = "pen"; words[2, 2] = "ручка";
            words[0, 3] = "солнце"; words[1, 3] = "sun"; words[2, 3] = "сонце";
            words[0, 4] = "яблоко"; words[1, 4] = "apple"; words[2, 4] = "яблуко";
            words[0, 5] = "стол"; words[1, 5] = "table"; words[2, 5] = "стіл";
        }
        public int GetLanguagesNumber() => words.GetLength(0);
        public string GetLanguage(int languageNumber) => words[0, languageNumber];
        public string this[string word, string langFrom, string langTo]
        {
            get
            {
                int indexFrom = -1;
                int indexTo = -1;
                for (int i = 0; i < words.GetLength(0); i++)
                {
                    if (words[i, 0] == langFrom.ToUpper())
                    {
                        indexFrom = i;
                    }
                    if (words[i, 0] == langTo.ToUpper())
                    {
                        indexTo = i;
                    }
                }
                if (indexFrom < 0 || indexTo < 0)
                {
                    string report = "";
                    if (indexFrom < 0)
                    {
                        report += string.Format($"Language {langFrom} invalid.\n");
                    }
                    if (indexTo < 0)
                    {
                        report += string.Format($"Language {langTo} invalid.\n");
                    }
                    report += "Valid languages collection:";
                    for (int i = 0; i < words.GetLength(0); i++)
                    {
                        report += " " + words[i, 0].ToString();
                    }
                    return report;
                }
                for (int i = 0; i < words.GetLength(1); i++)
                {
                    if (words[indexFrom, i] == word)
                    {
                        return words[indexTo, i];
                    }
                }
                return string.Format($"Not found translate to \"{word}\" from {langFrom} to {langTo}");
            }
        }
    }
}
