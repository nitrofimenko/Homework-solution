using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_20
{
    internal class Book
    {
        private const int NOTES_LIMIT = 100;
        private Notes[] notes = new Notes[NOTES_LIMIT];
        private int noteMaxNumber = -1;
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
        public int AddNote(string note)
        {
            noteMaxNumber++;
            notes[noteMaxNumber] = new Notes(note);
            return noteMaxNumber;
        }
        public void ChangeNote(int index, string note)
        {
            if (index >= 0 && index <= noteMaxNumber)
            {
                notes[index].ChangeNote(note);
            }
        }
        public string GetNote(int index)
        {
            if (index >= 0 && index <= noteMaxNumber)
            {
                return notes[index].GetNote();
            }
            else
            {
                return String.Format($"No note with #{index}.");
            }
        }
        public void ShowNote(int index)
        {
            if (index >= 0 && index <= noteMaxNumber)
            {
                notes[index].ShowNote();
            }
            else
            {
                Console.WriteLine($"No note with #{index}.");
            }
        }
        protected class Notes
        {
            private string note;
            public Notes(string note) => this.note = note;
            public void ChangeNote(string note) => this.note = note;
            public string GetNote() => note;
            public void ShowNote() => Console.WriteLine(note);
        }
    }
}
