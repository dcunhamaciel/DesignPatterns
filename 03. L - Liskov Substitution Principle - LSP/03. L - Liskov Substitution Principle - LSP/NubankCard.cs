abstract class NubankCard : IPaymentInstrument
{
    public virtual void CollectPayment()
    {
        Console.WriteLine("Pagamento realizado!");
    }

    public virtual void Validate()
    {
        Console.WriteLine("Validando cartão!");
    }
}