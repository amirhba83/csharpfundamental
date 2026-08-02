namespace HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(500, 500);//Size of console
            Console.BackgroundColor = ConsoleColor.DarkCyan;//Set Background color
            Console.ForegroundColor = ConsoleColor.Gray;//Set Text color
            Console.Title = "Hello World portal!";//Title
            Console.SetCursorPosition(3, 3);//Start of cursor
            Console.WriteLine("Hi! pleas enter your first name");
            string? firstName = Console.ReadLine() ?? "noName";
            Console.WriteLine("now enter your last name");
            string? lastName = Console.ReadLine() ?? "noLastName";
            Console.WriteLine("how old are you??");
            string age = Console.ReadLine() ?? "noAge";
            Console.WriteLine("you entered: " + firstName + " " + lastName);
            Console.WriteLine("and you are " + age + " years old");
            Console.ReadKey();
            // hello human readable



        }
    }
}
