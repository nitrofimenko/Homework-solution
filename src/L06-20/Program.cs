using L06_20;

Book book = new Book();

Console.Write("Book notes empty. Note #0: ");
book.ShowNote(0);
Console.WriteLine($"GetNote() test. GetNote(0): {book.GetNote(0)}");

int note1Number = book.AddNote("test0");
Console.WriteLine($"Note #{note1Number} added.");
book.ShowNote(note1Number);

book.ChangeNote(note1Number, "test1");
Console.WriteLine($"Note #{note1Number} changed.");
Console.WriteLine($"Note #{note1Number}: {book.GetNote(note1Number)}");

Console.Write("Note #1: ");
book.ShowNote(1);
Console.Write("Note #-1: ");
book.ShowNote(-1);