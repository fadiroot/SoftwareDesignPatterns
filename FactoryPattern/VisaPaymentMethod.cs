namespace FactoryPattern;

public class VisaPaymentMethod : IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Payment using Visa card");
    }
}