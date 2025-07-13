namespace processPaymentSystem;
public class PayPalPaymentProcessor : PaymentProcessor
{
  public string Email { get; set; }

  public override void ValidatePaymentDetails()
  {
    Console.WriteLine("Validating PayPal email...");
    if (string.IsNullOrWhiteSpace(Email))
      throw new Exception("Invalid PayPal account");
  }

  public override void ProcessPayment()
  {
    ValidatePaymentDetails();
    Console.WriteLine("Processing PayPal payment...");
    TransactionId = Guid.NewGuid().ToString();
  }
}