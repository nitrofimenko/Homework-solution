using L05_16;

Random rnd = new Random();
const int MIN = 3;
const int MAX = 7;
MyMatrix test = new MyMatrix(0, 0);
int rows;
int columns;
int start;
int number;
int startRow;
int endRow;
int startColumn;
int endColumn;
string choice = "";

while (choice != "0")
{
    Console.Clear();
    rows = rnd.Next(MIN, MAX);
    columns = rnd.Next(MIN, MAX);
    test = new MyMatrix(rows, columns);

    Console.WriteLine("Select demo:");
    Console.WriteLine("1. Add rows.");
    Console.WriteLine("2. Remove rows.");
    Console.WriteLine("3. Add columns.");
    Console.WriteLine("4. Remove columns.");
    Console.WriteLine("5. Resize matrix 1 type.");
    Console.WriteLine("6. Resize matrix 2 type.");
    Console.WriteLine("7. Show part of matrix.");
    Console.WriteLine("8. Get matrix dimensions.");
    Console.WriteLine("0. Break.");
    Console.WriteLine("Your choice: ");
    choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine($"\nTest matrix {rows}x{columns} ({rows} row(s), {columns} column(s)):");
            test.ShowMatrix();

            start = rnd.Next(0, test.GetRowsNumber());
            number = rnd.Next(1, MAX);
            Console.WriteLine($"\nAdd {number} zero rows starting from {start} row:");
            test.AddRows(start, number);
            test.ShowMatrix();

            Console.WriteLine("\nStrike a key");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine($"\nTest matrix {rows}x{columns} ({rows} rows, {columns} columns):");
            test.ShowMatrix();

            start = rnd.Next(0, test.GetRowsNumber());
            number = rnd.Next(1, MAX);
            Console.WriteLine($"\nRemove {number} rows starting from {start} row");
            test.DelRows(start, number);
            test.ShowMatrix();

            Console.WriteLine("\nStrike a key");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine($"\nTest matrix {rows}x{columns} ({rows} rows, {columns} columns):");
            test.ShowMatrix();

            start = rnd.Next(0, test.GetColumnsNumber());
            number = rnd.Next(1, MAX);
            Console.WriteLine($"\nAdd {number} zero columns starting from {start} column");
            test.AddColumns(start, number);
            test.ShowMatrix();

            Console.WriteLine("\nStrike a key");
            Console.ReadKey();
            break;
        case "4":
            Console.WriteLine($"\nTest matrix {rows}x{columns} ({rows} rows, {columns} columns):");
            test.ShowMatrix();

            start = rnd.Next(0, test.GetColumnsNumber());
            number = rnd.Next(1, MAX);
            Console.WriteLine($"\nRemove {number} columns starting from {start} column");
            test.DelColumns(start, number);
            test.ShowMatrix();

            Console.WriteLine("\nStrike a key");
            Console.ReadKey();
            break;
        case "5":
            Console.WriteLine($"\nTest matrix {rows}x{columns} ({rows} rows, {columns} columns):");
            test.ShowMatrix();

            rows = rnd.Next(MIN, MAX);
            columns = rnd.Next(MIN, MAX);
            test.ResizeMatrix(rows, columns);
            Console.WriteLine($"\nResize matrix to {rows}x{columns} ({rows} rows, {columns} columns), starting (0,0) cell:");
            test.ShowMatrix();

            Console.WriteLine("\nStrike a key");
            Console.ReadKey();
            break;
        case "6":
            Console.WriteLine($"\nTest matrix {rows}x{columns} ({rows} rows, {columns} columns):");
            test.ShowMatrix();

            rows = rnd.Next(MIN, MAX);
            columns = rnd.Next(MIN, MAX);
            startRow = rnd.Next(-MIN, MIN);
            startColumn = rnd.Next(-MAX, MAX);
            test.ResizeMatrix(rows, columns, startRow, startColumn);
            Console.WriteLine($"\nResize matrix to {rows}x{columns} ({rows} rows, {columns} columns), starting ({startRow},{startColumn}) cell. Bounds control off:");
            test.ShowMatrix();

            Console.WriteLine("\nStrike a key");
            Console.ReadKey();
            break;
        case "7":
            Console.WriteLine($"\nTest matrix {rows}x{columns} ({rows} rows, {columns} columns):");
            test.ShowMatrix();

            startRow = rnd.Next(0, rows);
            startColumn = rnd.Next(0, columns);
            endRow = rnd.Next(startRow, rows);
            endColumn = rnd.Next(startColumn, columns);
            Console.WriteLine($"\nShow matrix part from ({startRow},{startColumn}) to ({endRow},{endColumn}):");
            test.ShowPart(startRow, startColumn, endRow, endColumn);

            Console.WriteLine("\nStrike a key");
            Console.ReadKey();
            break;
        case "8":
            Console.WriteLine($"\nTest matrix {rows}x{columns} ({rows} rows, {columns} columns):");
            test.ShowMatrix();

            Console.WriteLine($"\nNumber of rows: {test.GetRowsNumber()}.");
            Console.WriteLine($"Number of columns: {test.GetRowsNumber()}.");
            Console.WriteLine("\nStrike a key");
            Console.ReadKey();
            break;
        default:
            break;
    }
}