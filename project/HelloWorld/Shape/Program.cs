using Shape;
using System.Security.Cryptography.X509Certificates;

namespace Shape;

internal class Program
{
    static void Main(string[] args)
    {
        //Circle c1 = new("Circle1", 5, Color.RED);
        //Rectangle r1 = new(4, 6, "Rectangle1");

        //c1.ShowInfo();
        //r1.ShowInfo();

        //c1.ChangeColor(Color.BLUE);
        //c1.ShowInfo();

        //static  void SendMessage(Message message)
        //{
        //    message.Send();
        //}
        //Message em1 = new EmaiMessage();
        //Message sm1 = new SmsMessage();
        //SendMessage(em1);
        //SendMessage(sm1);
        //List<Vehicle> vehicles = new List<Vehicle>();
        //vehicles.Add(new Car());
        //vehicles.Add(new Truck());
        //vehicles.Add(new Motorcycle());
        //foreach (Vehicle vehicle in vehicles)
        //{
        //    vehicle.Move();
        //}
        List<PaymentMethod> payments = new List<PaymentMethod>()
        {
            new CashPayment(100),
            new CreditCardPayment(200, "1234"),
            new OnlinePayment(300, "PayPal")
        };
        decimal totalFee=0;
        // here is the polymorphic behavior, we can call the Pay method on each payment method without knowing the specific type of payment method
        foreach (PaymentMethod payment in payments)
        {
            payment.Pay();
            totalFee += payment.GetProcessingFee();
        }
        Console.WriteLine($"Total processing fee: {totalFee}");

    }
}
//foreach (Vehicle vehicle in vehicles)
//{
//    if (vehicle is Car car )
//    {
//        car.NumberOfDoors = 4;
//    }
//}