public class Program
{
    public static void Main(string[] args)
    {
        //CreditCard card = new CreditCard();
        //DebitCard card = new DebitCard();
        NubankRewards card = new NubankRewards();

        card.Validate();
        card.CollectPayment();
    }
}