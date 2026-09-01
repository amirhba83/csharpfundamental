namespace Account;

internal class Program
{
    static void Main(string[] args)
    {
        UserAccount user1 = new UserAccount("user1", "123456");
        UserAccount user2 = new UserAccount("user2", "654321");
        user1.Login("12222");
        user1.Login("12444444");
        user1.Login("14555555");
        Console.WriteLine(user2.Login("4321"));
        //Console.WriteLine(user2.Password);
    }
}
