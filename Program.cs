using System;
using processPaymentSystem;
class Program
{
  static void Main()
  {
    PaymentProcessor payment = new CreditCardPaymentProcessor
    {
      Amount = 500.00m,
      CardNumber = "1234-5678-9012-3456"
    };
    payment.ProcessPayment();
    payment.PrintReceipt();

    PaymentProcessor paypal = new PayPalPaymentProcessor
    {
      Amount = 150.00m,
      Email = "user@example.com"
    };

    paypal.ProcessPayment();
    paypal.PrintReceipt();


  }
}