namespace processPaymentSystem;
public abstract class PaymentProcessor
{
  public string TransactionId { get; set; }
  public decimal Amount { get; set; }

  public abstract void ValidatePaymentDetails();
  public abstract void ProcessPayment();

  public void PrintReceipt()
  {
    Console.WriteLine($"Payment of {Amount} processed with Transaction ID: {TransactionId}");
  }

}