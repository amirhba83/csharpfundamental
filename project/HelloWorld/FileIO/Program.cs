using System.Text.Json;

namespace FileIO;

internal class Program
{
    static void Main(string[] args)
    {
        //File.WriteAllText("student333.txt", "ali");
        //File.AppendAllText("students.txt", "Reza");
        //File.AppendAllText("students.txt", "Mohsen");
        //string text = File.ReadAllText("students.txt");
        //string path = File.ReadAllText("C:\\Users\\laboo\\Desktop\\123.txt");
        //Console.WriteLine(path);
        //FileInfo fileInfo = new FileInfo("students.txt");
        //Console.WriteLine(fileInfo.Name);
        //Console.WriteLine(fileInfo.Length);
        //Console.WriteLine(fileInfo.CreationTime);
        

        //// converting object to json
        //List<Person> personList = new List<Person>
        //{
        //    new Person { Name = "Ali", LastName = "Ahmadi", Phone = "09123456789" },
        //    new Person { Name = "Reza", LastName = "Mohammadi", Phone = "09123456788" },
        //    new Person { Name = "Sara", LastName = "Karimi", Phone = "09123456787" }
        //};
        ////var options = new JsonSerializerOptions { WriteIndented = true };
        ////string jsonString = JsonSerializer.Serialize(personList, options);
        //// دو خط بالا راحی برای این بودند که فایل ما به صورت دندانه ای مرتب باشد 
        //string jsonString = JsonSerializer.Serialize(personList);
        //File.WriteAllText("C:\\Users\\laboo\\Desktop\\c#\\project\\HelloWorld\\FileIO\\j1.json", jsonString);
        //// converting json to object
        //string json = File.ReadAllText("C:\\Users\\laboo\\Desktop\\c#\\project\\HelloWorld\\FileIO\\j1.json");
        //List<Person> people = JsonSerializer.Deserialize<List<Person>>(json);
        //foreach (Person person in people)
        //{
        //    Console.WriteLine(person.Name);
        //}
        string path = @"C:\Users\laboo\Desktop\name.txt";
        if (!File.Exists(path))
        {
            Console.WriteLine("file not found");
            return;
        }
        using StreamReader streamReader = new StreamReader(path);
        int count = 0;
        while (!streamReader.EndOfStream)
        {
            string line = streamReader.ReadLine();
            //Console.WriteLine(count+1 + "-" + line);
            Console.WriteLine($"{count + 1}-{line}");
            count++;
        }
        Console.WriteLine("total count is:"+count);
    }
}
