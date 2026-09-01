namespace Shape;
#nullable disable
internal abstract class Shape
{
    public string Name { get; set; }
    public Shape (string name)
        => Name = name;
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public void ShowInfo()
    {
        Console.WriteLine($"" +
            $"Shape: {Name}\n" +
            $"Area: {GetArea():f2}\n" +
            $"Perimeter: {GetPerimeter():f2}");
    }
}
public interface IColorable
{
    public Color Color { get; set; }
    public void ChangeColor(Color newColor);
}

internal  class Circle : Shape, IColorable
{
    public Color Color { get ; set; }
    public double Radius { get; set; }
    public Circle(string name,double radius,Color color)
        :base(name)
    {
        Color = color;
        Radius = radius;
    }
    public void ChangeColor(Color newColor)
    {
        Color = newColor;
        Console.WriteLine($"color changed to {newColor}");
    }
    public  override double GetArea()
    {
        return ((double)Radius * Radius * double.Pi);
    }
    public override double GetPerimeter()
    {
        return ((double)Radius * 2 * 3.14);
    }
}
internal class Rectangle : Shape
{
    public double Width { get; set; }  
    public double Height { get; set; }
    
    public Rectangle(double width, double height, string name)
        : base(name)
    {
        Width = width;
        Height = height;
        
    }
    public override double GetArea()
    {
        return  ((double)Width * Height);

    }
    public override double GetPerimeter()
    {
        return 2 * ((double)Width + Height);

    }
}
public enum Color
{
    NOT_SET,
    RED,
    GREEN,
    BLUE,
    YELLOW,
}
