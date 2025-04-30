namespace FactoryPattern;

public class PaypalPaymentMethod:IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Payment using PayPal");
    }
}