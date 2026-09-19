namespace FileIO;

internal class Program
{
    static void Main(string[] args)
    {
        File.WriteAllText("student.txt", "ali");
        File.AppendAllText("students.txt", "Reza");
        File.AppendAllText("students.txt", "Mohsen");
        FileInfo fileInfo = new FileInfo("students.txt");
        Console.WriteLine(fileInfo.FullName);
        Console.WriteLine(fileInfo.UnixFileMode);
        Console.WriteLine(fileInfo.LinkTarget);



    }
}
