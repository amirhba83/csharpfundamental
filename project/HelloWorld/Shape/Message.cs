namespace Shape;

internal class Message
{
    public virtual void Send()
    {
    }
}
internal class EmaiMessage : Message
{
    public override void Send()
    {
        Console.WriteLine("Sending Email Message");
    }
}
internal class SmsMessage : Message
{
    public override void Send()
    {
        Console.WriteLine("Sending SMS Message");
    }
}

//-------------
public abstract class PaymentMethod
{
    #region constructor
    public PaymentMethod(decimal amount)
    {
        Amount = amount;
    }
    #endregion
    #region properties
    public decimal Amount { get; set; }
    #endregion
    #region methods
    abstract public void Pay();
    public virtual decimal  GetProcessingFee()
    {
        return 0;
    }
    #endregion
}
//-=------------------
public class CashPayment : PaymentMethod
{
    public CashPayment(decimal amount) : base(amount)
    {

    }
    public override void Pay()
    {
        Console.WriteLine($"paid {Amount} in cash");
    }
}
public class CreditCardPayment : PaymentMethod
{
    public string CardNumber { get; set; }
    public CreditCardPayment(decimal amount , string cardNumber) : base(amount)
    {
        CardNumber = cardNumber;
    }
    public override void Pay()
    {
        Console.WriteLine($"Paid {Amount} with card ending in {CardNumber}");
    }
    public override decimal GetProcessingFee()
    {
        return Amount * 0.02m;
    }
}
public class OnlinePayment : PaymentMethod
{
    public string Provider { get; set; }
    public OnlinePayment(decimal amount , string provider) : base(amount)
    {
        Provider = provider;
    }
    public override void Pay()
    {
        Console.WriteLine($"Paid {Amount} online via {Provider}");
    }
    public override decimal GetProcessingFee()
    {
        return 5000;
    }
}