public class Program
{
    public static void Main(string[] args)
    {
        //PayPal payment = new PayPal();
        //Payonner payment = new Payonner();
        IPayPalPayment payment = new PayonnerAdapter(new Payonner());
        payment.PayPalPayment();
        payment.PayPalReceive();
    }
}