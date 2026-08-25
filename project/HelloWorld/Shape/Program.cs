using Shape;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new("Circle1", 5, Color.RED);
            Rectangle r1 = new(4, 6, "Rectangle1");

            c1.ShowInfo();
            r1.ShowInfo();

            c1.ChangeColor(Color.BLUE);
            c1.ShowInfo();

            
        }
    }
}