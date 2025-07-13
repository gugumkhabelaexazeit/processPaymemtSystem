namespace processPaymentSystem;
public class CreditCardPaymentProcessor : PaymentProcessor
{
  public string? CardNumber { get; set; }

  public override void ValidatePaymentDetails()
  {
    Console.WriteLine("Validating credit card number...");
    if (string.IsNullOrWhiteSpace(CardNumber))
      throw new Exception("Invalid card number");
  }
  public override void ProcessPayment()
  {
    ValidatePaymentDetails();
    Console.WriteLine("Processing credit card payment...");
    TransactionId = Guid.NewGuid().ToString();
  }
}