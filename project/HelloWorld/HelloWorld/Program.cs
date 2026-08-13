using HelloWorld;
using System.Text;
using static HelloWorld.Book;

namespace HelloWord
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
            Car samand = new Car(brand: "irankhodro", model: "samand", year: 1405);
            samand.Start();
            Car car1 = new Car();
            car1.Start();



        }

    }
}
