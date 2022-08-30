using System.Collections.Generic;
using L05_18;

void ShowTranslate(Dictionary dictionary, string word, string langFrom, string langTo)
{
    Console.WriteLine($"Trying translate \"{word}\" from {langFrom} to {langTo}... " +
        $"{dictionary[word, langFrom, langTo]}");
}
Dictionary dictionary = new Dictionary();
string ru = "ru";
string en = "en";
string ua = "ua";
ShowTranslate(dictionary, "книга", ru, en);
ShowTranslate(dictionary, "дом", ru, en);
ShowTranslate(dictionary, "ручка", ru, en);
ShowTranslate(dictionary, "стол", ru, en);
ShowTranslate(dictionary, "карандаш", ru, en);
ShowTranslate(dictionary, "книга", ru, en);
ShowTranslate(dictionary, "яблоко", ru, en);
ShowTranslate(dictionary, "солнце", ru, en);