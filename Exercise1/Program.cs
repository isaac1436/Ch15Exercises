Console.Write("What would you like to name your file: ");
string fileName = Console.ReadLine();

var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
path = Path.Combine(path, $"{fileName}.txt");

StreamWriter writer = new StreamWriter(path);

Console.Write("\nHow many lines will your file have: ");
int lineNo = int.Parse(Console.ReadLine());

using (writer)
{
    for (int i = 0; i < lineNo; i++)
    {
        Console.Write($"\nLine{i + 1}: \t");
        writer.WriteLine(Console.ReadLine());
    }
    Console.WriteLine("\n");
}


StreamReader reader = new StreamReader(path);
string line = reader.ReadLine();
lineNo = 0;

while (line != null)
{
    lineNo++;

    if (lineNo % 2 != 0)
    {
        Console.WriteLine($"Line{lineNo}:\t{line}\n");  
    }
    line = reader.ReadLine();
}

reader.Close();

File.Delete(path);