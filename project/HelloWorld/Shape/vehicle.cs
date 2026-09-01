namespace Shape;
internal abstract class Vehicle
{
    internal virtual void Move()
    {
        Console.WriteLine("Vehicle is moving");
    }
}
internal class Car : Vehicle
{
    internal override void Move()
    {
        Console.WriteLine("Car is moving");
    }
}
internal class Truck : Vehicle
{
    internal override void Move()
    {
        Console.WriteLine("Truck is moving");
    }   
}
internal class Motorcycle : Vehicle
{
    internal override void Move()
    {
        Console.WriteLine("Motorcycle is moving");
    }
}

