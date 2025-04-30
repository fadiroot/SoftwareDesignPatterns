// See https://aka.ms/new-console-template for more informa

using FactoryPattern;

var paymentFactory =new PaymentFactory() ;
var visaPaymentMethod = paymentFactory.Create(PaymentMethod.Visa) ;
visaPaymentMethod.Pay();