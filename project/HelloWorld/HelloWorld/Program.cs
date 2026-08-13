
namespace HelloWorld
{
     internal class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student("Ali", 20, 18);  
            //Student student2 = new Student("Akbar", 12, 8);
            //Student student3 = new Student("Asghar", 3, 9);
            //student1.ShowInfo();
            //student2.ShowInfo();
            //student3.ShowInfo();
            //Rectangle rectangle = new Rectangle(5, 10);
            //rectangle.ShowInfo();
            //rectangle.Scale(2);
            //rectangle.ShowInfo();
            Account a1 = new Account("Ali", 1000);
            Account a2 = new Account("mahmood", 200);
            Account a3 = new Account("Akbar", 500000);
            a1.ShowBalance();
            a2.ShowBalance();
            a3.ShowBalance();
            a1.Deposit(555);
            a2.Withdraw(300);
            a1.ShowBalance();
            a2.ShowBalance();
            Account.ShowTotalAccounts();



        }

    }
}
