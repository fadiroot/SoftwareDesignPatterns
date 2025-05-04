// See https://aka.ms/new-console-template for more informa

using System.Reflection;
using FactoryPattern;

var paymentFactory =new PaymentFactory() ;
var visaPaymentMethod = paymentFactory.Create(PaymentMethod.Visa) ;
var asmb = Assembly.GetExecutingAssembly();
Console.WriteLine(asmb);
visaPaymentMethod.Pay();
 