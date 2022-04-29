var path1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
path1 = Path.Combine(path1, $"Ex2File1.txt");

StreamWriter writer1 = new StreamWriter(path1);

var path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
path2 = Path.Combine(path2, $"Ex2File2.txt");

StreamWriter writer2 = new StreamWriter(path2);

using (writer1)
{
    for (int i = 0; i < 10; i++)
    {
        writer1.WriteLine($"File 1, Line {i + 1} : {(i + 1) * 2}");
    }
}

using (writer2)
{
    for (int i = 0; i < 10; i++)
    {
        writer2.WriteLine($"File 2, Line {i + 1} : { (i + 1) * 5}");
    }
}

var path3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
path3 = Path.Combine(path3, $"Ex2File3.txt");

StreamWriter writer3 = new StreamWriter(path3);
StreamReader reader1 = new StreamReader(path1);
StreamReader reader2 = new StreamReader(path2);

using (writer3)
{
    for (int i = 0; i < 10; i++)
    {
        string line = reader1.ReadLine() + " \t " + reader2.ReadLine();
        writer3.WriteLine(line);
    }
}

StreamReader reader3 = new StreamReader(path3);

using (reader3)
{
    for (int i = 0; i < 10; i++)
    {
        string line = reader3.ReadLine();
        Console.WriteLine(line);
    }

}