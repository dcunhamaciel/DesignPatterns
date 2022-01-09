public interface IPayPalPayment
{
    public Token AuthToken();
    public void PayPalPayment();
    public void PayPalReceive();
}