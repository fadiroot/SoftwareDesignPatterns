namespace FactoryPattern;

public  class PaymentFactory
{
    private readonly Dictionary<PaymentMethod, Func<IPaymentMethod>> _paymentsMethods;

    public PaymentFactory()
    {
        _paymentsMethods = new Dictionary<PaymentMethod, Func<IPaymentMethod>>
        {
            { PaymentMethod.Paypal, () => new PaypalPaymentMethod() },
            { PaymentMethod.Visa, () => new VisaPaymentMethod() },
            { PaymentMethod.CreditCart, () => new CreditCardPayment() }
        }; 

    }
    public IPaymentMethod Create(PaymentMethod paymentMethod)
    {
       if (_paymentsMethods.TryGetValue(paymentMethod ,out var creator))
       {
           return creator();

       }
       throw new NotSupportedException($"Payment method '{paymentMethod}' is not supported.");
       
      
    }
}