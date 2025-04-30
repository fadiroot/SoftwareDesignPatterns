namespace FactoryPattern;

public class CreditCardPayment  : IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Payment using Credit Card");
    }
}