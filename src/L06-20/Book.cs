using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_20
{
    internal class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
        public int AddNote(string note) => Notes.AddNote(note);
        public void ChangeNote(int index, string note) => Notes.ChangeNote(index, note);
        public string GetNote(int index) => Notes.GetNote(index);
        public void ShowNote(int index) => Notes.ShowNote(index);
        private static class Notes
        {
            private static string[] notes = new string[100];
            private static int noteMaxNumber = -1;
            public static int AddNote(string note)
            {
                notes[++noteMaxNumber] = note;
                return noteMaxNumber;
            }
            public static void ChangeNote(int index, string note)
            {
                if (index >= 0 && index <= noteMaxNumber)
                {
                    notes[index] = note;
                }
            }
            public static string GetNote(int index) => (noteMaxNumber < 0 || index < 0 || index > noteMaxNumber) ? "" : notes[index];
            public static void ShowNote(int index)
            {
                if (noteMaxNumber < 0)
                {
                    Console.WriteLine("No notes");
                }
                else
                {
                    if (index < 0 || index > noteMaxNumber)
                    {
                        Console.WriteLine($"Not have note #{index}");
                    }
                    else
                    {
                        Console.WriteLine($"Note #{index}: {notes[index]}");
                    }
                }
            }
        }
    }
}
